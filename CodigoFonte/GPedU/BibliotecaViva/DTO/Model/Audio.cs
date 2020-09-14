﻿using System.Data.SQLite.Tools;

namespace BibliotecaViva.DTO.Model
{
    public class Audio : CorpoDocumento
    {
        [PrimaryKey, Indexed]
        public int? Documento { get; set; }
        public string Base64 { get; set; }
    }
}