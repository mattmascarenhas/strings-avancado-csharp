namespace StringsAvancado {
    internal class Program {
        static void Main(string[] args) {
            //======================ID-GUID============================
            var id = Guid.NewGuid();  //serve para gerar id
            id.ToString(); //transformando o id em string

            Console.WriteLine(id);
            //atribuindo um valor para o id, se nao passar um parametro gera um id com tudo 0
            id = new Guid("1a92e8c6-639f-48b7-b2e3-c1d12e115f75");
            Console.WriteLine(id.ToString().Substring(0,8)); //so pegando os primeiros 8 caracteres

            Console.WriteLine("=====================================================");
            //======================INTERPOLAÇÃO============================
            float price = 10.2f;
            bool boole = true;
            
            //interpolaçao vai sempre converter para string 
            string text = "O preço do produto é: " + price + boole;
            string text2 = $"O preço do produto é R${price}";
            string text3 = @"O @ ignora caracteres especiais, tipo o \n";

            Console.WriteLine(text);
            Console.WriteLine(text2);
            Console.WriteLine(text3);

            Console.WriteLine("=====================================================");

            //======================COMPARAR STRINGS============================
            string text4 = "Esse texto é um teste";
            Console.WriteLine(text4.Contains("Teste")); //verifica se contem 
            Console.WriteLine(text4.CompareTo("Teste")); //verifica se é igual, se 0 TRUE, se -1 FALSE
            Console.WriteLine(text4.Contains("Teste", StringComparison.OrdinalIgnoreCase)); //ignora o case sentive
 
            Console.WriteLine("=====================================================");

            //======================STARTS WITH/ENDS WITH============================
            string text5 = "Testando o Starts With e Ends With";

            Console.WriteLine(text5.StartsWith("Testando")); //true
            Console.WriteLine(text5.StartsWith("testando")); //false
            Console.WriteLine(text5.StartsWith("testando", StringComparison.OrdinalIgnoreCase)); //true

            Console.WriteLine(text5.EndsWith("With")); //true
            Console.WriteLine(text5.EndsWith("with")); //false
            Console.WriteLine(text5.EndsWith("with", StringComparison.OrdinalIgnoreCase)); //true

            Console.WriteLine("=====================================================");

            //======================EQUALS============================
            string text6 = "Testando o EQUALS";

            Console.WriteLine(text6.Equals("Testando o EQUALS")); //true
            Console.WriteLine(text6.Equals("testando o EQUALS")); //false
            Console.WriteLine(text6.Equals("testando o equals", StringComparison.OrdinalIgnoreCase)); //true

            Console.WriteLine("=====================================================");

            //======================INDICES/INDEX============================
            string text7 = "Testando o index ";
            Console.WriteLine(text7.IndexOf("i")); //mostra a posiçao de um determinado elemento, usado para qqr tipo
            Console.WriteLine(text7.IndexOf("n")); //ele pega o primeiro achado
            Console.WriteLine(text7.LastIndexOf("n")); //ele pega o ultimo achado

            Console.WriteLine("=====================================================");

            //======================TO LOWER/TO UPPER/INSERT/REMOVE============================
            string text8 = "Testando o TO LOWER E TO UPPER ";

            Console.WriteLine(text8.ToLower());
            Console.WriteLine(text8.ToUpper());
            Console.WriteLine(text8.Insert(10, "AQUI"));
            Console.WriteLine(text8.Remove(5,5));

            Console.WriteLine("=====================================================");

            //======================REPLACE/SPLIT============================
            string text9 = "Testando o replace e split";

            Console.WriteLine(text9.Replace("e", "E"));
            Console.WriteLine(text9.Replace("e", "E"));

            var split = text9.Split(" ");

            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);
            Console.WriteLine(split[3]);

            Console.ReadLine();
        }
    }
}