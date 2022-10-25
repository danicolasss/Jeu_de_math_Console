namespace nb_jeu_de_math
{
    class MainClass
    {
        static Random Random = new Random();
        const int min = 1;
        const int max = 9;


        private static int GetOperateur ()
        {// + * - /
            
            int operateur = Random.Next(1,4);
            return operateur;   

        }


        private static bool DemanderOperation()
        {
            int nombreUtilisateur = 0;
            int operation = GetOperateur();

            int A = Random.Next(min, max);
            int B = Random.Next(min, max);

            int resultatOperation = 0;

            while (true)
            {
                switch (operation)
                {
                    case 1:
                        Console.Write("Combien fait " + A + " + " + B + " : ");
                        resultatOperation = A + B;
                        break;
                    case 2:
                        Console.Write("Combien fait " + A + " - " + B + " : ");
                        resultatOperation = A - B;
                        break;
                    case 3:
                        Console.Write("Combien fait " + A + " * " + B + " : ");
                        resultatOperation = A * B;
                        break;
                    case 4:
                        Console.Write("Combien fait " + A + " / " + B + " : ");
                        resultatOperation = A / B;
                        break;

                }



                
                string resultat = Console.ReadLine();
            
                if (int.TryParse(resultat, out nombreUtilisateur))
                // la conversion c'est bien passée
                {
               
                    if (nombreUtilisateur == resultatOperation)
                    {
                        Console.WriteLine("c'est exate");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Non c'était " + resultatOperation);
                        return false;   
                    }
                }
                else
                //erreur de la conversion
                {
                    Console.WriteLine("Erreur vous devez rentrer un nombre");
                } 
            }

        }
        public static void Main(string[] args)
        {
            const int Nb_question = 5;
            int note = 0;
            for (int i = 0; i < Nb_question; i++)
            {
                Console.WriteLine("Question n° "+(i+1)+"/" +Nb_question);
                if (DemanderOperation())
                {
                    note++;
                }
            }
            string resultat = note + "/5";
            Console.WriteLine("");

            switch (note)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine(resultat+" Peut mieux faire");
                    break;
                case 3:
                case 4:
                    Console.WriteLine(resultat + " Pas mal !");
                    break;
                case 5:
                    Console.WriteLine(resultat + " Bravo !");
                    break;
            }

            
        }
    }
}


