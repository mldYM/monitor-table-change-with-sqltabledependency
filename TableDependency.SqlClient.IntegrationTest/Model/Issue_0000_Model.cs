﻿using System;

namespace TableDependency.SqlClient.IntegrationTest.Model
{
    public class Issue_0000_Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Born { get; set; }

        // Column not present in Customer database table
        public string City { get; set; }
    }
}