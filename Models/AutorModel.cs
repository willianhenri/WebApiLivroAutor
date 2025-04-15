﻿using System.Text.Json.Serialization;

namespace WebApi.Models {
    public class AutorModel {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore]
        public ICollection<LivroModel> Livros { get; set; }
    }
}
