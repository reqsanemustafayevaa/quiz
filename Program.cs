using System.Security.Cryptography;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Register
            //2.Login

            //Əgər 1 - i seçsək bizden user yaranmasi ucun lazim olan butun datalari teleb etmelidir ve user yaranib, static Users listine elave olunacaq.
            //Əgər 2 - i seçsək bizden username ve password teleb etmelidir ve eger dogru yazilibsa, Blog Menu acilmalidir, eks halda yeniden teleb etmeyi istemelidir.

            //<======== Blog Menu ========>
            //1.Blog elave et  
            //2.Blog sil
            //3.Blog detail
            //4.Butun bloglara bax
            //5.Bloglari filterle
            //0.Proqramı bitir


            //Bu menu pəncərəsi görsəndikdən dərhal sonra proqram bizdən bir seçim etməyimizi istəməlidir

            //Əgər 1 - i seçsək Blog yaradib static liste elave etmelidir.Blogun butun deyerleri daxil edilib, BlogType'a catanda bizden secim etmeyimizi istemelidir - Mes: (1 - Programming, 2 - Educational, 3 - Thriller), eger 1 secsek, yaranan blogun BlogType Programming olmalidir.

            //Əgər 2 - ni seçsək, id teleb etmelidir eger varsa, static listden silmelidir.

            //Əgər 3 - ni seçsək, id teleb etmelidir eger varsa, hemin blogun title ve descriptionunu gostermelidir. 

            //Əgər 4 - ü seçsək butun bloglari gostermelidir.

            //Əgər 5 - i seçsək string value teleb etmelidir, ve sherte uygun butun bloglari gostermelidir.

            //Əgər 0 - ı seçsək proses bitməlidir.

        }
    }
}