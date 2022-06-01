using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Mana.Contracts.Share;
using Mana.ShareModule;

namespace AutoReplace
{
    public class ConfigHelper
    {
        public static  SuccessFailResult bindComboBoxWithConfigFile (ComboBoxItem pComboxItem)
        {
            List<ValueObject<string>> pFileList = new List<ValueObject<string>>();
            string pConfigPath = Application.StartupPath + "\\Config";
            if (!Directory.Exists(pConfigPath))
            {
                Directory.CreateDirectory(pConfigPath);
                return SuccessFailResult.mDoNothing;
            }
            string[] pJsonFiles = Directory.GetFiles(pConfigPath, "*.json", SearchOption.TopDirectoryOnly);
            if (pJsonFiles.Length <= 0)
            {
                return SuccessFailResult.mDoNothing;
            }
            foreach (var pFile in pJsonFiles)
            {
                pFileList.Add(new ValueObject<string>(Path.GetFileNameWithoutExtension(pFile), pFile));
            }
            pComboxItem.ComboBoxEx.DataSource = pFileList;
            pComboxItem.ComboBoxEx.DisplayMember = ValueObject<string>.displayMemeber;
            pComboxItem.ComboBoxEx.ValueMember = ValueObject<string>.valueMember;

            if (pComboxItem.Items.Count > 0)
            {
                pComboxItem.SelectedIndex = 0;
            }
            return SuccessFailResult.mSuccess;
        }
    }
}
