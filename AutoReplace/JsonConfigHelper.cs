using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mana.ShareModule;
using Mana.Contracts.Share;
using System.IO;
using Newtonsoft.Json;

namespace AutoReplace
{
   public  class JsonConfigHelper
    {

        public static SuccessFailResult<T>  readFile<T>(string pConfigFile)
        {
            if (string.IsNullOrWhiteSpace(pConfigFile))
            {
                return SuccessFailResult<T>.createFail("空白的文件名");
            }
            if(pConfigFile.EndsWith(".json") == false)
            {
                pConfigFile += ".json";
            }
            if (!File.Exists(pConfigFile))
            {
                return SuccessFailResult<T>.createFail($"配置文件[{pConfigFile }]不存在");
            }
            var pText = File.ReadAllText(pConfigFile, System.Text.Encoding.Unicode);
            if (string.IsNullOrWhiteSpace(pText))
            {
                return SuccessFailResult<T>.createFail($"配置文件[{pConfigFile }]为空");
            }
            try
            {
                T pConfig = JsonConvert.DeserializeObject<T>(pText);
                return SuccessFailResult<T>.createSuccess(pConfig);
            }
            catch(Exception exp)
            {
                return SuccessFailResult<T>.createExceptionFail($"解析配置文件[{pConfigFile}]异常", exp);
            }

        }

        public static SuccessFailResult writeToFile<T>(T pConfig,string pConfigFile)
        {
            try
            {
                var pSerialize = JsonConvert.SerializeObject(pConfig);
                File.WriteAllText(pConfigFile, pSerialize,Encoding.Unicode);
                return SuccessFailResult.mSuccess;
            }
            catch (Exception exp)
            {
                return SuccessFailResult.createExceptionFail($"序列化对像并保存文件[{pConfigFile}]异常", exp);
            }

        }
    }
}
