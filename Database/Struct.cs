namespace JewelCreator.Database
{
    public struct CreateJevelLegendStruct
    {
        public string Mod { get; set; }
        public float Power { get; set; }
        public string Description { get; set; }

        public CreateJevelLegendStruct(string mod = "", float power = 1f, string desc = "null")
        {
            Mod = mod;
            Power = power;
            Description = desc;
        }
    }
}
