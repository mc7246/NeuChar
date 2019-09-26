﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2019 Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2019 Senparc
    
    文件名：RequestMessageNeuChar.cs
    文件功能描述：接收 NeuChar 消息
    
    
    创建标识：Senparc - 20180829
    
    修改标识：Senparc - 20190105
    修改描述：v0.6.0 添加 PullNeuCharAppConfig 消息类型

----------------------------------------------------------------*/


namespace Senparc.NeuChar.Entities
{
    /// <summary>
    /// NeuChar 请求消息
    /// </summary>
    public class RequestMessageNeuChar : RequestMessageBase, IRequestMessageBase
    {
        public override RequestMsgType MsgType
        {
            get { return RequestMsgType.NeuChar; }
        }

        /// <summary>
        /// 具体操作类型
        /// </summary>
        public NeuCharActionType NeuCharMessageType { get; set; }

        /// <summary>
        /// 设置信息（通常为JSON）
        /// </summary>
        public string ConfigRoot { get; set; }

        /// <summary>
        /// 请求数据的 JSON 字符串
        /// </summary>
        public string RequestData { get; set; } = string.Empty;
    }
}
