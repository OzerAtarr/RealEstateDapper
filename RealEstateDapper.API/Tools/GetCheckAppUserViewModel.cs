﻿namespace RealEstateDapper.API.Tools
{
    public class GetCheckAppUserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public bool IsExist { get; set; } //rol bu kullanıcı için tanımlı mı
    }
}
