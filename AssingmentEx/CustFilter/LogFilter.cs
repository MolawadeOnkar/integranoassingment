using AssingmentEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssingmentEx.CustFilter
{
    public class LogFilter:ActionFilterAttribute
    {
        companycontext db = new companycontext();
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            //LogTbl lt = new LogTbl();
            //lt.ActionName = filterContext.ActionDescriptor.ActionName;
            //lt.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            //lt.LogDateTime = DateTime.Now;
            //entity.LogTbls.Add(lt);
            //entity.SaveChanges();
        }
    }
}