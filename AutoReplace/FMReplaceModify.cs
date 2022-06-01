using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Mana.Contracts.Share;
using Mana.ShareModule;
using System.IO;

namespace AutoReplace
{
    public partial class FMReplaceModify : Form
    {
        public FMReplaceModify()
        {
            InitializeComponent();
        }

        private void xClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FMReplaceModify_Load(object sender, EventArgs e)
        {
            var pStart = start();
            if(pStart.mResult == EMSuccessFail.resultFail )
            {
                MessageBox.Show(pStart.mInfo, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private SuccessFailResult start()
        {
            var pResult = ConfigHelper.bindComboBoxWithConfigFile(xProjectList);
            if(pResult.mResult != EMSuccessFail.resultSuccess)
            {
                return pResult;
            }
            return  loadData().toSuccessFailResult();
        }
               
        private  SuccessFailResult loadOneProject(string pFile)
        {
            var pLoadResult = JsonConfigHelper.readFile<List<ConfigReplaceItem>>(pFile);
            if (pLoadResult.mResult == EMSuccessFail.resultSuccess)
            {
                return showDataGridData(pLoadResult.mValue);
            }
            return pLoadResult;
        }

        private SuccessFailResult showDataGridData(List<ConfigReplaceItem> pData)
        {
            xDataGridView.Rows.Clear();
            if(pData == null || pData.Count <= 0)
            {
                return SuccessFailResult.mDoNothing;
            }
            try
            {
                foreach (var p in pData)
                {
                    xDataGridView.Rows.Add(p.mOld, p.mNew);
                }
                return SuccessFailResult.mSuccess;
            }
            catch (Exception exp)
            {
                return SuccessFailResult.createExceptionFail($"显示表格数据异常", exp);
            }
        }

        private void showHelp(string pHelpInfo)
        {
            xHelp.Text = pHelpInfo;
            xStatus.Invalidate(true);
        }

        private void xLoad_Click(object sender, EventArgs e)
        {
            var pLoad = loadData();
            if (pLoad.mResult != EMSuccessFail.resultSuccess )
            {
                showHelp(pLoad.mInfo);
            }
            else
            {
                showHelp($"成功导入{pLoad.mValue}");
            }
        }

        private SuccessFailResult<string> loadData()
        {
            var pGetFileResult = getSelectConfigFile();
            if (pGetFileResult.mResult != EMSuccessFail.resultSuccess )
            {
                return pGetFileResult;
            }
            return  loadOneProject(pGetFileResult.mValue).toSuccessFailResult<string>(pGetFileResult.mValue);
        }

        private void xSave_Click(object sender, EventArgs e)
        {
            var pGetDataResult = getDataFromDataGrid();
            if(pGetDataResult.mResult != EMSuccessFail.resultSuccess)
            {
                showHelp(pGetDataResult.mInfo);
                return;
            }
            var pGetFileResult = getSelectConfigFile();
            if (pGetFileResult.mResult == EMSuccessFail.resultFail )
            {
                showHelp(pGetDataResult.mInfo);
                return;
            }else if (pGetFileResult.mResult == EMSuccessFail.resultDoNothing )
            {
                var pSaveResult = saveToNewFile(pGetDataResult.mValue);
                if (pSaveResult.mResult != EMSuccessFail.resultSuccess)
                {
                    showHelp(pSaveResult.mInfo);
                }
                else
                {
                    showHelp($"成功保存配置文件：{pSaveResult.mValue}");
                    ConfigHelper.bindComboBoxWithConfigFile(xProjectList);       //重新刷新列表
                }
                return;
            }
            else
            {
                var pSaveResult = saveToFileInner(pGetDataResult.mValue, pGetFileResult.mValue);
                if (pSaveResult.mResult != EMSuccessFail.resultSuccess)
                {
                    showHelp(pSaveResult.mInfo);
                }
                else
                {
                    showHelp($"成功保存配置文件：{pGetFileResult.mValue}");
                }
            }

        }
        private void xSaveNew_Click(object sender, EventArgs e)
        {
            var pGetDataResult = getDataFromDataGrid();
            if (pGetDataResult.mResult != EMSuccessFail.resultSuccess)
            {
                showHelp(pGetDataResult.mInfo);
                return;
            }
            var pSaveResult = saveToNewFile(pGetDataResult.mValue);
            if (pSaveResult.mResult != EMSuccessFail.resultSuccess)
            {
                showHelp(pSaveResult.mInfo);
            }
            else
            {
                showHelp($"成功保存配置文件：{pSaveResult.mValue}");
                ConfigHelper.bindComboBoxWithConfigFile(xProjectList);       //重新刷新列表
            }
            return;
        }

        private SuccessFailResult<List<ConfigReplaceItem>> getDataFromDataGrid()
        {
            List<ConfigReplaceItem> pNewList = new List<ConfigReplaceItem>();
            try
            {
                foreach (DataGridViewRow p in xDataGridView.Rows)
                {
                    if (!p.IsNewRow)
                    {
                        string pOld = Convert.ToString(p.Cells[0].Value);
                        string pNew = Convert.ToString(p.Cells[1].Value);
                        if (!string.IsNullOrEmpty(pOld))
                        {
                            pNewList.Add(new ConfigReplaceItem(pOld, pNew));
                        }
                    }
                }
                return SuccessFailResult<List<ConfigReplaceItem>>.createSuccess(pNewList);
            }
            catch (Exception exp)
            {
                return SuccessFailResult<List<ConfigReplaceItem>>.createExceptionFail($"解析表格数据异常", exp);
            }

        }

        private SuccessFailResult<string> getSelectConfigFile()
        {
            if (xProjectList.SelectedIndex < 0 || xProjectList.Items.Count <= 0)  //如果当前没有现成方案，按另存为方式走
            {
                return SuccessFailResult<string>.mDoNothing;
            }
            var pItem = (ValueObject<string>)xProjectList.Items[xProjectList.SelectedIndex];
            return SuccessFailResult<string>.createSuccess(pItem.mValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>包含新的文件名</returns>
        private SuccessFailResult<string> saveToNewFile(List<ConfigReplaceItem> pData)
        {
            var pResult = inputBox("请输入文件名,后缀名使用默认json", "文件名", "ReplaceConfig");
            if(pResult.mResult == EMOKCancel.resultCancel)
            {
                return SuccessFailResult<string>.mDoNothing;
            }
            var pInput = pResult.mValue;
            var pPath =  Application.StartupPath + "\\Config\\" + pInput + ".json";
            return saveToFileInner(pData, pPath).toSuccessFailResult<string>(pPath);
        }


        private SuccessFailResult saveToFileInner(List<ConfigReplaceItem> pData, string pConfigFile)
        {
            return JsonConfigHelper.writeToFile<List<ConfigReplaceItem>>(pData, pConfigFile);
        }

        public static OKCancelResult<string> inputBox(string title, string promptText,string pDefault  = "")
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            form.Text = title;
            label.Text = promptText;
            textBox.Text = pDefault;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);
            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                return OKCancelResult<string>.createOK(textBox.Text);
            }
            else
            {
                return OKCancelResult<string>.mCancel;
            }
        }

        private void xClear_Click(object sender, EventArgs e)
        {
            xDataGridView.Rows.Clear();
        }

        private void xProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
