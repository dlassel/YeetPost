﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YeetPostV1_4.DataModel
{
    public class Yeet
    {
        public string date;

        public string Guid;

        public string header;

        public string totalLikes;

        public string username;

        public List<string> whoLikes;

        public string yeet;
        public string location;
    }
}