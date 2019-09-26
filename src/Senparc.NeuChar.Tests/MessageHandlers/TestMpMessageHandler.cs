﻿using Senparc.NeuChar.Context;
using Senparc.NeuChar.Entities;
using Senparc.Weixin.MP.Entities;
using Senparc.Weixin.MP.Entities.Request;
using Senparc.Weixin.MP.MessageHandlers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Senparc.NeuChar.Tests.MessageHandlers
{
    /// <summary>
    /// 测试公众号 MessageHandler
    /// </summary>
    public class TestMpMessageHandler : MessageHandler<TestMpMessageContext>
    {
        public TestMpMessageHandler(XDocument requestDoc, PostModel postModel = null, int maxRecordCount = 0)
                : base(requestDoc, postModel, maxRecordCount)
        {
        }

        public TestMpMessageHandler(RequestMessageBase requestMessage, PostModel postModel = null, int maxRecordCount = 0)
            : base(requestMessage, postModel, maxRecordCount)
        {
        }

        public override IResponseMessageBase DefaultResponseMessage(IRequestMessageBase requestMessage)
        {
            var responseMessage = this.CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content = "来自单元测试消息的默认响应消息";
            return responseMessage;
        }
    }
}
