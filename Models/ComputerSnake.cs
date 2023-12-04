namespace HelloWorld.Models
{

        public class ComputerSnake{

            public int computer_id {get;set;}
            public string motherboard {get; set;} = "";
            public int? cpu_cores {get; set;} = 0;
            public bool has_wifi {get; set;}
            public bool has_lte {get; set;}
            public DateTime? release_date {get; set;}
            public decimal price {get; set;}
            public string video_card {get; set;} = "";

            // We can create a constructor to set the string values to blank strings OR we can set them in the setter & getter declarations. 
            // public ComputerSnake()
            // {
            //     if (video_card == null)
            //     {
            //         video_card ="";
            //     }
            //     if(motherboard == null)
            //     {
            //         motherboard = "";
            //     }
            // }
        }
}