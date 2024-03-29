﻿using FundAChild.Domain.Entities;
using FundAChild.WebUI.Models.Orders;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FundAChild.WebUI.Controllers
{
    public class OrdersController : BaseController
    {
        // GET: Orders
        public ActionResult Index()
        {
            ViewBag.Active = "Orders";

            var model = new OrderListViewModel
            {
                Orders = context.Orders.ToList()
            };
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var order = context.Orders.SingleOrDefault(p => p.OrderId == id);
            if (order == null)
            {
                return HttpNotFound();
            }

            var model = new OrderStatus(order);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(OrderStatus model)
        {
            if (ModelState.IsValid)
            {
                var order = context.Orders.SingleOrDefault(p => p.OrderId == model.OrderId);
                order = model.ParseAsEntity(order);

                context.Entry(order).State = EntityState.Modified;
                context.SaveChanges();
            }else
            {
                ShowError("Data unstable");

                return View("Edit", model);
            }

            ShowSuccess("Order status updated successfully");

            return RedirectToAction("Index");
        }
    }
}