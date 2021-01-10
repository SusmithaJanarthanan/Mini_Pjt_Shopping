﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Mini_Pjt_Shopping.Models;

namespace Mini_Pjt_Shopping.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CheckOutController : ApiController
    {
        MiniProject_ShopEntities2 entities = new MiniProject_ShopEntities2();

        [HttpGet]
        [ActionName("GetOrdersCart")]

        public HttpResponseMessage GetOrdersfromCart(int id)
        {
            List<Order> order = new List<Order>();
            var res = entities.sp_getOrdersfromCart(id).ToList();
            foreach (var item in res.ToList())
            {
                order.Add(new Order { Prod_Name = item.Prod_Name, Prod_Price = item.Prod_Price });
            }
            return Request.CreateResponse(HttpStatusCode.OK, order);
        }
        [HttpPut]
        [ActionName("InsInToOrd")]
        public HttpResponseMessage InsertIntoOrders(int id,Product pdt)
        {
            var res = entities.sp_ins_order(id);
            entities.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);

           
        }

    }
}
