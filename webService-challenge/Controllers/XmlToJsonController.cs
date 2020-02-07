﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;
using Newtonsoft.Json;
using ClassLibrary;

namespace webService_challenge.Controllers
{

    public class XmlToJsonController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static string XmlToJson(string xml)
        {
            if (xml == null)
            {
                return "Error in method XmlToJson :  null parameter";
            }
            try
            {
                return ClassLibrary.Convert.XmlToJson(xml);
            }
            catch (Exception e)
            {
                log.Error(e.StackTrace);
                return "Bad Xml format";
            }

        }
    }
}
