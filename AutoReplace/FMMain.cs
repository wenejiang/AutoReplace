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

namespace AutoReplace
{
    public partial class FMMain : Form
    {

        public List<ConfigReplaceItem> mReplaceList;
        

        public FMMain()
        {
            InitializeComponent();
        }

        private void xClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xPaste_Click(object sender, EventArgs e)
        {
            xInput.Text =  Clipboard.GetText();
           
        }
        private void xInput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(xInput.Text))
            {
                var pResult = replaceText(xInput.Text);
                if (pResult.mResult == EMSuccessFail.resultSuccess)
                {
                    showHelp(pResult.mInfo);
                    xOutput.Text = pResult.mValue;
                }
                else if (pResult.mResult == EMSuccessFail.resultFail)
                {
                    showHelp(pResult.mInfo);
                    xOutput.Text = string.Empty;
                }
                else
                {
                    showHelp("未执行替换");
                    xOutput.Text = string.Empty;
                }
            }
        }

        private void xCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(xOutput.Text);
        }

        private SuccessFailResult<string> replaceText(string pInputText)
        {
            if(mReplaceList == null || mReplaceList.Count <= 0)
            {
                return SuccessFailResult<string>.mDoNothing;
            }
            if(string.IsNullOrWhiteSpace(pInputText))
            {
                return SuccessFailResult<string>.mDoNothing;
            }
            var pOutput = pInputText;
            foreach(var p in mReplaceList)
            {
                var pReplaceResult = replaceTextInner(pOutput, p.mOld , p.mNew );
                if(pReplaceResult.mResult == EMSuccessFail.resultSuccess)
                {
                    if(!xMultiReplace.Checked)  //如果未选择多次替换，则成功一次即可退出
                    {
                        return pReplaceResult;
                    }
                    else
                    {
                        pOutput = pReplaceResult.mValue;  //转给中间变量，继续替换
                    }
                }
            }
            if (!xMultiReplace.Checked)
            {
                return SuccessFailResult<string>.mDoNothing;    //如果是只替换一次就结束的模式，则执行到这里，返回nothing
            }
            else
            {
               return SuccessFailResult<string>.createSuccess(pOutput);
            }
        }

        private SuccessFailResult<string> replaceTextInner(string pInputText,string pOldText,string pNewText)
        {
            if (string.IsNullOrWhiteSpace(pInputText))
            {
                return SuccessFailResult<string>.mDoNothing;
            }
            if (string.IsNullOrEmpty(pOldText))
            {
                return SuccessFailResult<string>.mDoNothing;
            }
            var pOutputText = pInputText.Replace(pOldText, pNewText);
            if (pOutputText.Equals(pInputText))
            {
                return SuccessFailResult<string>.mDoNothing;
            }
            else
            {
                var pReturn =  SuccessFailResult<string>.createSuccess(pOutputText);
                pReturn.mInfo = $"{pOldText}已成功替换为{pNewText}";
                return pReturn;
            }
        }

        private void FMMain_Load(object sender, EventArgs e)
        {
            var pResult = start();
            if(pResult.mResult != EMSuccessFail.resultSuccess)
            {
                showHelp(pResult.mInfo);
            }
            else
            {
                showHelp("就绪");
            }
        }
        private void xProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pResult = loadData();
            if (pResult.mResult != EMSuccessFail.resultSuccess)
            {
                showHelp(pResult.mInfo);
            }
            else
            {
                showHelp($"{pResult.mValue}就绪");
            }
        }

        private SuccessFailResult start()
        {
            var pResult = ConfigHelper.bindComboBoxWithConfigFile(xProjectList);
            if (pResult.mResult != EMSuccessFail.resultSuccess)
            {
                return pResult;
            }
            return loadData().toSuccessFailResult();
        }

        private SuccessFailResult<string> loadData()
        {
            var pGetFileResult = getSelectConfigFile();
            if (pGetFileResult.mResult != EMSuccessFail.resultSuccess)
            {
                return pGetFileResult;
            }
            return loadOneProject(pGetFileResult.mValue).toSuccessFailResult<string>(pGetFileResult.mValue);
        }

        private SuccessFailResult loadOneProject(string pFile)
        {
            var pReadResult =   JsonConfigHelper.readFile<List<ConfigReplaceItem>>(pFile);
            if(pReadResult.mResult == EMSuccessFail.resultSuccess)
            {
                mReplaceList = pReadResult.mValue;
            }
            return pReadResult;
        }

        private SuccessFailResult<string> getSelectConfigFile()
        {
            if (xProjectList.SelectedIndex < 0 || xProjectList.Items.Count <= 0)  //如果当前没有现成方案，按另存为方式走
            {
                return SuccessFailResult<string>.createDoNothing("未配置替换项");
            }
            var pItem = (ValueObject<string>)xProjectList.Items[xProjectList.SelectedIndex];
            return SuccessFailResult<string>.createSuccess(pItem.mValue);
        }

        private void showHelp(string pHelpInfo)
        {
            xHelp.Text = pHelpInfo;
            xStatus.Invalidate(true);
        }

        private void xConfig_Click(object sender, EventArgs e)
        {
            var pFM = new FMReplaceModify();
            pFM.ShowDialog();
            pFM.Dispose();

            var pResult = start();      //重新刷新一下
            if (pResult.mResult != EMSuccessFail.resultSuccess)
            {
                showHelp(pResult.mInfo);
            }
            else
            {
                showHelp("就绪");
            }
        }
    }
}
