﻿namespace API.DTOs
{
    public class OrderDTO
    {
        public string ShoppingCartId { get; set; }
        public int DeliveryMethodId { get; set; }
        public AddressDTO ShippingAddress { get; set; }
        public string EmailAddress { get; set; }
    }
}
