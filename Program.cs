using System;


namespace week6day3
{
    public interface IAnime{
        void showAnime();
    }
    public class AnimeComedy : IAnime
    {
        public void showAnime()
        {
            Console.WriteLine("A Comedy Anime will be shown");
        }
    }
    public class AnimeDrama : IAnime
    {
        public void showAnime()
        {
            Console.WriteLine("A Drama Anime will be shown");
        }
    }
    public class AnimeHorror : IAnime
    {
        public void showAnime()
        {
          Console.WriteLine("A Horror Anime will be shown");   
        }
    }
    public class Default : IAnime
    {
        public void showAnime()
        {
          Console.WriteLine("not avalible");   
        }
    }
    public class AnimeFactory{
        public static IAnime GetAnime(string animeType){
            if(animeType == null){
                return null;
                }		
                else if(animeType.Equals(("Comedy"), StringComparison.OrdinalIgnoreCase)){
                    return new AnimeComedy();
                    
                } else if(animeType.Equals(("Drama"), StringComparison.OrdinalIgnoreCase)){
                    return new AnimeDrama();
                    
                } else if(animeType.Equals(("Horror"), StringComparison.OrdinalIgnoreCase)){
                    return new AnimeHorror();
                }
                else
                    return new Default();
                }
                        }
   

    class Program
    {
        static void Main(string[] args)
        {
            AnimeFactory animeFactory= new AnimeFactory();

            IAnime c1 = AnimeFactory.GetAnime("COMEDY");
            c1.showAnime();

            IAnime c2 = AnimeFactory.GetAnime("Drama");
            c2.showAnime();

            IAnime c3 = AnimeFactory.GetAnime("Horror");
            c3.showAnime();

            IAnime c4 = AnimeFactory.GetAnime("School");
            c4.showAnime();


        }
    }
}
