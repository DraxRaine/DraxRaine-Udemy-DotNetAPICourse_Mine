namespace HelloWorld.Models
{

        public class Computer{
            public string Motherboard {get; set;} = "";
            public int CPUCores {get; set;}
            public bool HasWifi {get; set;}
            public bool HasLTE {get; set;}
            public DateTime ReleaseDate {get; set;}
            public decimal Price {get; set;}
            public string VideoCard {get; set;} = "";

            // We can create a constructor to set the string values to blank strings OR we can set them in the setter & getter declarations. 
            // public Computer()
            // {
            //     if (VideoCard == null)
            //     {
            //         VideoCard ="";
            //     }
            //     if(Motherboard == null)
            //     {
            //         Motherboard = "";
            //     }
            // }
        }
}