//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace PlayStoreML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("col0"), LoadColumn(0)]
        public float Col0 { get; set; }


        [ColumnName("id"), LoadColumn(1)]
        public float Id { get; set; }


        [ColumnName("track_name"), LoadColumn(2)]
        public string Track_name { get; set; }


        [ColumnName("size_bytes"), LoadColumn(3)]
        public float Size_bytes { get; set; }


        [ColumnName("currency"), LoadColumn(4)]
        public string Currency { get; set; }


        [ColumnName("price"), LoadColumn(5)]
        public float Price { get; set; }


        [ColumnName("rating_count_tot"), LoadColumn(6)]
        public float Rating_count_tot { get; set; }


        [ColumnName("rating_count_ver"), LoadColumn(7)]
        public float Rating_count_ver { get; set; }


        [ColumnName("user_rating"), LoadColumn(8)]
        public float User_rating { get; set; }


        [ColumnName("user_rating_ver"), LoadColumn(9)]
        public float User_rating_ver { get; set; }


        [ColumnName("ver"), LoadColumn(10)]
        public string Ver { get; set; }


        [ColumnName("cont_rating"), LoadColumn(11)]
        public string Cont_rating { get; set; }


        [ColumnName("prime_genre"), LoadColumn(12)]
        public string Prime_genre { get; set; }


        [ColumnName("sup_devices_num"), LoadColumn(13)]
        public float Sup_devices_num { get; set; }


        [ColumnName("ipadSc_urls_num"), LoadColumn(14)]
        public float IpadSc_urls_num { get; set; }


        [ColumnName("lang_num"), LoadColumn(15)]
        public float Lang_num { get; set; }


        [ColumnName("vpp_lic"), LoadColumn(16)]
        public float Vpp_lic { get; set; }


    }
}
