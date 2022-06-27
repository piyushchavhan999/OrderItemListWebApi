﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItemListWebApi.Models
{
    public class OrderItem
    {
        [Key]

        public int Id { get; set; }

        public int UserId { get; set; }
        public int MenuItemId { get; set; }


        public string Name { get; set; }
    }
}
