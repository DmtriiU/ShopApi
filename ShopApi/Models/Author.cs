﻿namespace ShopApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Surname { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty; 
        public string Patronymic { get; set; } = string.Empty;
    }
}
