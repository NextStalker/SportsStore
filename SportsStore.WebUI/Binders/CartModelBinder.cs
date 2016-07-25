using System;
using System.Web.Mvc;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string SESSION_KEY = "Cart";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Cart cart = (Cart)controllerContext.HttpContext.Session[SESSION_KEY];

            if (cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session[SESSION_KEY] = cart;
            }

            return cart;
        }
    }
}