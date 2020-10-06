using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using WebApiSample.Common;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [RoutePrefix("api/PrintType")]
    public class PrintTypeController : ApiController
    {
        // GET: api/PrintType
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            List<PrintTypeModel> result = DbPrintType.Instance.GetAllList();

            if (result != null && result.Count > 0)
            {
                return Json(result);
            }
            return Json("Select PrintType Error or Empty!");
        }

        // GET: api/PrintType/5
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            PrintTypeModel result = DbPrintType.Instance.GetId(id);
            if (result != null)
            {
                return Json(result);
            }
            return Json("Select PrintType By Id Error or Empty!");
        }

        // POST: api/PrintType
        [HttpPost]
        [Route("")]
        public IHttpActionResult Post(FormDataCollection form)
        {
            var values = form.Get("values");

            var printType = JsonConvert.DeserializeObject<PrintTypeModel>(values);

            int result = DbPrintType.Instance.InsertDb(printType);
            if (result > 0)
            {
                //nếu insert thành công thì trả về data vừa insert vào
                return Json(DbPrintType.Instance.GetId(DbPrintType.Instance.GetMaxId()));
            }
            return Json("Insert print type error!");
        }

        // PUT: api/PrintType/5
        [HttpPut]
        [Route("")]
        public IHttpActionResult Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");

            var printType = JsonConvert.DeserializeObject<PrintTypeModel>(values);
            printType.PrintTypeId = key;

            int result = DbPrintType.Instance.UpdateDb(printType);

            return Ok(result);
        }

        // DELETE: api/PrintType/5
        public void Delete(int id)
        {
        }
    }
}
