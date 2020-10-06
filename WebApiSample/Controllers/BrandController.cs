using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using WebApiSample.Common;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [RoutePrefix("api/brands")]

    public class BrandController : ApiController
    {
        // GET api/values
        //dung actribute
        [Route("")]//đặt định tuyến để truy cập đến API
        [HttpGet]//các từ khóa để xác định chức năng của phương thức
        public IHttpActionResult Get()
        {
            List<BrandModel> result = DbBrand.Instance.GetAllList();

            if (result.Count > 0 && result != null)
            {
                return Json(result);
            }

            return Json("Select Brand Error!");
        }

        // GET /5
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            BrandModel result = DbBrand.Instance.GetId(id);
            if (result !=null)
            {
                return Json(result);
            }
            return Json("Select Brand By Id Error!");
        }

        //POST data client truyen len su dung kieu FromBody
        [HttpPost]
        [Route("insert")]
        public IHttpActionResult Post([FromBody]BrandModel brand)
        {
            int indexId = DbBrand.Instance.GetMaxId() + 1;

            int result = DbBrand.Instance.InsertDb(brand);

            if (result > 0)
            {
                return Json(DbBrand.Instance.GetId(indexId));
            }
            return Json("Insert Loi");
        }

        /// <summary>
        /// Insert data. ../brand/insert.
        /// </summary>
        /// <param name="form">Data truyền lên kiểu x-www-form-urlencoded.</param>
        /// <returns>OK, Trả về model chứa thông tin data vừa insert vào.</returns>
        [HttpPost]
        [Route("")]
        public IHttpActionResult Post(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            //Kiem tra key tren database co ton tai hay khong

            var brand = JsonConvert.DeserializeObject<BrandModel>(values);

            int result = DbBrand.Instance.InsertDb(brand);

            if (result > 0)
            {
                //nếu insert thành công thì trả về data vừa insert vào
                return Json(DbBrand.Instance.GetId(DbBrand.Instance.GetMaxId()));
            }
            return Json("Insert brand error!");
        }

        // PUT 
        /// <summary>
        /// Update Data. ../brand.
        /// </summary>
        /// <param name="form">Data truyền lên kiểu x-www-form-urlencoded.</param>
        /// <returns>trả về kết quả 1 là update thành công.</returns>
        [HttpPut]
        [Route("")]
        public IHttpActionResult Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            //Kiem tra key tren database co ton tai hay khong

            var brand = JsonConvert.DeserializeObject<BrandModel>(values);
            brand.BrandId = key;

            int result = DbBrand.Instance.UpdateDb(brand);

            return Ok(result);//trả về kết quả 1 là update thành công
        }
    }
}
