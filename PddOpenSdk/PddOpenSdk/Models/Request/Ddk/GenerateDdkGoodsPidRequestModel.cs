using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GenerateDdkGoodsPidRequestModel : PddRequestModel
    {
        /// <summary>
        /// 要生成的推广位数量，默认为10，范围为：1~100
        /// </summary>
        [JsonProperty("number")]
        public long Number { get; set; }
        /// <summary>
        /// 推广位名称，例如["1","2"]
        /// </summary>
        [JsonProperty("p_id_name_list")]
        public List<string> PIdNameList { get; set; }
        public partial class PIdNameListRequestModel : PddRequestModel
        {

        }

    }

}
