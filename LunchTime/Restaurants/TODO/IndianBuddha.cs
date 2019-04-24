﻿using LunchTime.Models;
using System;
using System.Device.Location;

namespace LunchTime.Restaurants.TODO
{
    public class IndianBuddha : RestaurantBase
    {
        public override string Name => "Indian buddha";

        public override string Url => "http://www.indian-restaurant-buddha.cz/";

        public override string Web => "";

        public override GeoCoordinate Location => new GeoCoordinate(49.1950608, 16.6073800);

        public override City City => City.Brno;

        public override LunchMenu Get()
        {
            throw new NotImplementedException();
        }
   }
}