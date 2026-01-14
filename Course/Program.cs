using Course.Entities;
using Course.Entities.Enums;
using Course.Entities.Model;
using Course.Services;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System;
using System.ComponentModel;


namespace Course
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Order order = new Order { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };
            Console.WriteLine(order);

            //conversão de string para enum
            OrderStatus orderStatus = Enum.Parse<OrderStatus>("PendingPayment");
            */

            ////EXERCÍCIO COMPOSIÇÃO

            /*
            Console.Write("Entre com o nome do departamento: ");
            string departamentName = Console.ReadLine();
            Departament department = new Departament(departamentName);

            Console.Write("Entre com o nome do trabalhador: ");
            string name = Console.ReadLine();

            Console.Write("Entre com o núvel do trabalhador (Junior/Pleno/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Digite o salário base do funcionário: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, level, salary, department);

            Console.Write("Quantos contratos para esse trabalhador? ");
            int quantContract = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantContract; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dado do contrato {i}: ");

                Console.Write("Preço por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Horas trabalhadas: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Data (dd/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Entre com mês e ano para calcular o ganho (MM/YYYY): ");
            string[] serchDate = Console.ReadLine().Split('/');
            double income = worker.Income(int.Parse(serchDate[1]), int.Parse(serchDate[0]));
            Console.WriteLine(income);

            */

            //DESAFIO COMPOSIÇÃO - stringbuilder

            /*
            Console.Write("Nome do cliente: ");
            string clientName = Console.ReadLine();
            Client client = new Client(clientName);



            Console.Write("Quantos itens no pedido: ");
            int quantOrderItem = int.Parse(Console.ReadLine());

            Order order = new Order(client);

            for (int i = 1; i <= quantOrderItem; i++)
            {
                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();

                Console.Write("Valor produto: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantidade do produto: ");
                int quantProduct = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(quantProduct, product);
                order.AddItem(item);

            }

            Console.WriteLine("Resumo do Pedido:");
            Console.WriteLine(order.ToString());
            */


            //HERANÇA

            /*
            Account account = new Account(1001, "Alex", 0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Tim", 500, 100);
            SavingAccount savingAccount = new SavingAccount(1003, "Alice", 500, 0.01);

            businessAccount.Withdraw(10);
            savingAccount.Withdraw(10);
            Console.WriteLine(businessAccount.Balance.ToString() + savingAccount.Balance.ToString());

            ////UPCASTING

            Account acc1 = businessAccount; 
            acc1 não tem tudo que tem em businessAccount, só o que tem dentro de account, ele se molda ao tipo 

            ////DOWNCASTING

            BusinessAccount acc2 = acc1 as BusinessAccount;
            Console.WriteLine(acc2.LoanLimit);
            */

            //POLIMORFISMO
            //EXERCÍCIO DOS FUNCIONÁRIO DE DIFERENTES CLASSES

            /*
            Console.Write("Quantos funcionários irá cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> listEmployee = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Empregado {i}: ");

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Valor da Hora: ");
                double valueHours = double.Parse(Console.ReadLine());

                Console.Write("É terceirizado (y/n) ? ");
                char outsourced = char.Parse(Console.ReadLine());

                if (outsourced == 'y')
                {
                    Console.Write("Adicional: ");
                    double addicinalCharge = double.Parse(Console.ReadLine());
                    listEmployee.Add(new OutsourcedEmployee(name, hours, valueHours, addicinalCharge));

                }
                else
                {
                    listEmployee.Add(new Employee(name, hours, valueHours));
                }


            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");

            listEmployee.ForEach(employee =>
            {
                Console.WriteLine($"{employee.Name} - $ {employee.payment()}");
            });
            */

            //DESAFIO POLIMORFISMO

            /*
            Console.Write("Quantos produtos há para cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Produto #{i} ");

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Produto comum, importado ou usado (c/i/u)? ");
                char type = char.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Taxa de importação: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));

                }
                if (type == 'u')
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {

                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            products.ForEach(product =>
            {
                Console.WriteLine($"{product.PriceTag()}");
            });
            */

            //CLASSE ABSTRADA
            //não posso criar uma instancia de uma classe abstrata
            // Se eu tenho um método abstrado a classe também é.

            //DESAFIO CLASSE ABSTRADA

            /*
            Console.Write("Quantos contribuintes deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Contribuinte> contribuintes = new List<Contribuinte>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Contribuinte #{i} ");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                Console.Write("Pessoa Física ou Jurídica (F/J)? ");
                char type = char.Parse(Console.ReadLine());

                if (type == 'F')
                {
                    Console.Write("Gasto com saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine());
                    contribuintes.Add(new ContribuintePessoaFisica(nome, rendaAnual, gastoSaude));

                }
                else
                {
                    Console.Write("Quantidade Funcionários: ");
                    int quantFuncionario = int.Parse(Console.ReadLine());
                    contribuintes.Add(new ContribuintePessoaJuridica(nome, rendaAnual, quantFuncionario));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double somaImposto = 0;
            contribuintes.ForEach(contribuinte =>
            {
                Console.WriteLine($"{contribuinte.ToString()}");
                somaImposto += contribuinte.ImpostoAPagar();
            });

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: {somaImposto}");
            */

            //TRATAMENTO DE EXCEÇÕES - EXERCÍCIO DE FIXAÇÃO

            /*
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Saldo: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Limite de saque: ");
            double limite = double.Parse(Console.ReadLine());

            Conta conta = new Conta(numero, saldo, limite);
            Console.Write("Quanto deseja sacar: ");
            double saque = double.Parse(Console.ReadLine());

            try
            {
                conta.Sacar(saque);
                Console.WriteLine($"saldo: {conta.Saldo}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            */

            //TRABALHANDO COM ARQUIVOS

            /*
            //Realiza operações com arquivos (create, copy, delete, move, open, etc.) e ajuda na criação de objetos FileStream.
            //FILE - não precisa instanciar, mas faz verificação a cada etapa´. É mais lento (ideal para coisas simples)
            //FILEINFO - preciso instanciar, mas depois as operações são mais rápidas. (ideal para coisas mais complexas)
            //Nesses dois casos eu uso para lidar com arquivos (copiar, deletar, renomear, mover...)


            string sourcePath = @"C:\EstudoProgramacao\c_sharp\file1.txt";
            string targetPath = @"C:\EstudoProgramacao\c_sharp\file2.txt";

            try
            {

                FileInfo fileInfo = new FileInfo(sourcePath); // ou uso File.Copy(sourcePath, targetPath); 
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (var item in lines)
                {
                    Console.WriteLine(item);
                }

            }
            catch (HttpIOException error)
            {
                Console.WriteLine(error.Message);
            }
            */

            //Seçaõ 11 - aula 131 FileStream e StreamReader

            /*
            //FILE STREAM: Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita (é uma stream binária) (acessa o recurso de entrada e saída)
            //Encapsula a sequencia de leitura/escrita em um recurso entrada/saída (vulgo arquivo).
            //STREAM READER: Converte de texto para binário e vice-versa. Ele pega esse stream disponibilizado pelo file stream e converte para texto. (tenho o recurso otimizado para o que eu quero)

            string path = @"C:\EstudoProgramacao\c_sharp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.Write(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            

            //uma outra forma de fazer, pra não precisar instanciar o filestream e o streamreader: sr = File.OpenText(path); Esse cara já instancia os dois de cima

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) //lendo todo o arquivo
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

            //BLOCO USING : Quando lidamos com essas coisas que não são gerenciadas pelo CLI do .NET precisamos fechar (bloco finaliy), com o using isso é fechado automaticamente

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occrred");
                Console.WriteLine(e.Message);
            }
            */

            //Seção 11 - aula 133 Stream Write: Usado para escrever arquivos

            /*
            string sourcePath = @"C:\EstudoProgramacao\c_sharp\file1.txt";
            string targetPath = @"C:\EstudoProgramacao\c_sharp\file3.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            //Seção 11 - aula 134 Directory e DirectoryInfo

            /*
            //DIRECTORY  (Estático) E DIRECTORYINFO (Instancia) = Operações com pastas
             
            string path = @"C:\CombinandoCores";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach(string s in folders){
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }
            }
            catch( IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }*/

            //Seção 11 - aula 135 Path

            /*
            //Path - realiza operações com string que contenham caminhos de pastas ou arquivos.

            string path = @"C:\Estudo Investimentos\Notas de negociação\_STVM_1207616_005484215_2684942_202535_1741206312768.pdf__assinado.pdf";

            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            */

            //Seção 11 - aula 136 Exercício de fixação

            /*string sourceFile = @"C:\EstudoProgramacao\c_sharp\sourceFile.txt";

            try
            {                         
                string[] lines = File.ReadAllLines(sourceFile);
                string sourceFolderPath = Path.GetDirectoryName(sourceFile);

                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";
                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product2 prod = new Product2(name, price, quantity);

                        sw.WriteLine(prod.Name + ";" + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }*/

            //Seção 12 - aula 139 Interfaces

            /*
            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
            */

            //Seção 12 - aula 143 - Exercício de fixação

            /*Console.Write("Entre com o número do contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());

            Console.Write("Entre com a data do contrato (dd/MM/yyyy): ");
            DateOnly dataContrato = DateOnly.Parse(Console.ReadLine());

            Console.Write("Entre com o valor do contrato: ");
            double valorContrato = double.Parse(Console.ReadLine());

            Console.Write("Entre com a quantidade de parcelas: ");
            int quantParcelas = int.Parse(Console.ReadLine());



            Contrato contrato = new Contrato(numeroContrato, dataContrato, valorContrato);
            ContratoService contratoService = new ContratoService(new PaypalService());
            contratoService.ProcessarContrato(contrato, quantParcelas);

            Console.WriteLine("Valor a ser paga das parcelas:");
            foreach(Parcela parcela in contrato.Parcelas)
            {
                Console.WriteLine(parcela);
            }*/


            //Seção 12 - aula 144 - Diferença entre herdar e cumprir contrato

            /*IShape circulo = new Circle() { Color = "Branca", Radius = 2 };
            IShape retangulo = new Rectangle() { Color = "Preta", Largula = 3, Altura = 2 };
            Console.WriteLine(circulo);
            Console.WriteLine(retangulo);*/

            //Seção 12 - aula 145 - Herança múltipla e problema do diamante

            //Não é possível fazer herança múltipla, porque teríamos ambiguidade. Um método com múltiplas implementações.
            //Tem que refatorar a estrutura, para uma classe herdar da outra, e implementar as duas interfaces.
            //Estou herdando de uma classe e implementando duas interfaces

            //Seção 12 - aula 146 - Interface IComparable
            //Serve para comparar um objeto com o outro. Pra dizer se é maior, menor ou igual ao outro
            //Quando li string consegui comparar pq a classe string já implementa a interface IComparable, mas quando passei a comparar funcionário, precisei implementar a interface em funcionário e fazer a lógica de comparação que eu aplicaria
            // Quando ele chamar o sort, ele vai usar esse método que implementei em funcionário    

            /*string path = @"C:\EstudoProgramacao\c_sharp\listaNome.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Funcionario funcionario in list)
                    {
                        Console.WriteLine(funcionario);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro", e.Message);
            }*/


            //Seção 13 - aula 148 - Generics
            //Como essa classe foi criada do tipo generic <T>, na hora que eu instancio eu escolho o tipo
            //Assim posso usar tanto para string, como para int, por exemplo. Forma de reaproveitamento

            /*PrintService<int> printService = new PrintService<int>();

            Console.Write(" Quantos números deseja ler? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.Firt());*/


            //Seção 13 - aula 150 - Restrição aos generics

            /* List<Produto> list = new List<Produto>();
             Console.Write("Entre com n: ");
             int n = int.Parse(Console.ReadLine());
             for (int i = 0; i < n; i++)
             {
                 string[] vect = Console.ReadLine().Split(',');
                 double preco = double.Parse(vect[1], CultureInfo.InvariantCulture);
                 list.Add(new Produto(vect[0], preco));
             }
             CalculationService calculationService = new CalculationService();
             Produto produto = calculationService.Max(list);
             Console.WriteLine("Mais caro: " + produto);*/

            //Seção 13 - aula 151 - GetHashCode (rápido, resposta positiva não é 100%) e Equals (mais lento, resposta 100%)
            // Dica para muitas análises use o mais rápido, se der positivo testar com o equals para ter certeza.


            /* Client2 a = new Client2 { Name = "Maria", Email = "maria@gmail.com" };
             Client2 b = new Client2 { Name = "Alex", Email = "maria@gmail.com" };

             Console.WriteLine(a.Equals(b)); //compara dentro do critero que eu sobrescrevi na classe, nesse caso olho o email
             Console.WriteLine(a.GetHashCode()); //nesses caso deu igual pq é a mesma iteração.
             Console.WriteLine(b.GetHashCode());
             Console.WriteLine(a == b); //compara a refêrencia do ponteiro de alocação em memória do objeto*/

            //Seção 14 - aula 152 - HashSet e SortedSet

            //Quando não admitir repetição de elementos no lugar de List eu uso um dos dois.
            //Cunjunto não tem posição, diferente da lista e vetor.
            //Acesso, remoção e iserção são rápidos.
            //Oferece operações eficientes de conjunto (interseção, união de diferença)
            //HashSet: Armazenamento em tabela hash, ordem dos elementos não é garantida. O(1) muito rápido, mais que o outro
            //SortedSet: Armazenamento em árvore, os elementos são armazenados ordenadamente conforme implementação do IComparer. O(log(n)) é rápido mas o outro é mais

            /*
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
            */

            //Seção 13 - aula 153 - HashSet e SortedSet Parte 2
            /*
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c); // como é sortedset sempre vai mostrar pra mim os elementos ordenados

           //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
            */

            //Seção 13 - aula 154 - Como coleções Hash comparam igualdades

            /*
            HashSet<Product3> a = new HashSet<Product3>();
            a.Add(new Product3("TV", 900));
            a.Add(new Product3("Notebook", 1200));

            Product3 product3 = new Product3("Notebook", 1200);
            Console.WriteLine(a.Contains(product3)); //false
            //Embora o product3 seja igual a um produto dentro de a, o contains dá false porque ele não olha o valor, ele olha o hash, a alocação de memória
            // isso porque o gethashcode e equals NAO está implementado, então ele compara a referencia dos objetos.
            //mas se estiver implementado, caso de string, por exemplo, ele olha primeiro o gethashcode que é mais rápido e depois confirma com o equals.

            //agora vou implementar o getHashCode e equals na classe product3 e tem que dar verdadeiro


            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Point point = new Point(5, 10);
            Console.WriteLine(b.Contains(point)); 
            //true, aqui dá true, não precisa fazer o override porque é struct
            */

            //Seção 13 - aula 155 - exercício de fixação

            /*
            Console.Write(" Enter file full path: ");
            string path = Console.ReadLine();

            HashSet<LogRecord> set = new HashSet<LogRecord>();
            //aqui eu uso o hashset pq a ordem não importa, então uso o mais rápido. caso contrário poderia usar o sortedset

            try
            {
                using(StreamReader sr = File.OpenText(path)) //C:\EstudoProgramacao\c_sharp\log_alunos.txt
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                                              
                    }
                    Console.Write("Total: " + set.Count);
                }
            }catch(IOException ex)
            {
                Console.Write(ex.Message);
            }
            */

            //Seção 13 - aula 156 - exercício proposto

            /*
            HashSet<int> cursoA = new HashSet<int>();
            Console.Write("Quantos alunos na turma A? ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int matricula = int.Parse(Console.ReadLine());
                cursoA.Add(matricula);
                
            }

            HashSet<int> cursoB = new HashSet<int>();
            Console.Write("Quantos alunos na turma B? ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                int matricula = int.Parse(Console.ReadLine());
                cursoB.Add(matricula);

            }

            HashSet<int> cursoC = new HashSet<int>();
            Console.Write("Quantos alunos na turma C? ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                int matricula = int.Parse(Console.ReadLine());
                cursoC.Add(matricula);

            }

            HashSet<int> totalAlunosAlex = new HashSet<int>(cursoA);
            totalAlunosAlex.UnionWith(cursoB);
            totalAlunosAlex.UnionWith(cursoC);

            Console.WriteLine("Total " + totalAlunosAlex.Count);
            */

            // Seção 13 - aula 157 - Dictionary e SortedDictionary
            // Coleção de pares de chave e valor
            //Sorted é organizado em árvore conforme o ICompared

            /* Dictionary<string, string> cookies = new Dictionary<string, string>();
             cookies["user"] = "maria";
             cookies["email"] = "marial@gmail.com";
             cookies["phone"] = "35998475412";

             cookies.Remove("email");

             if (cookies.ContainsKey("email"))
             {
                 Console.WriteLine(cookies["email"]);
             }

             Console.WriteLine(cookies.Count);

             foreach (KeyValuePair<string, string> item in cookies)
             {
                 Console.WriteLine(item.Key + ": " + item.Value);
             }*/

            //Seção 13 - aula 158 - exercício proposto

            /* Dictionary<string, int> votacao = new Dictionary<string, int>();

             try
             {
                 string path = "C:\\EstudoProgramacao\\c_sharp\\votos.txt";
                 using (StreamReader sr = File.OpenText(path)) 
                 {
                     while (!sr.EndOfStream)
                     {
                         string[] line = sr.ReadLine().Split(',');
                         string name = line[0];
                         int voto = int.Parse(line[1]);
                         if (votacao.ContainsKey(name))
                         {
                             votacao[name] += voto;
                         }
                         else
                         {
                             votacao[name] = voto;
                         }

                     }
                     foreach (KeyValuePair<string, int> item in votacao)
                     {
                         Console.WriteLine(item.Key + ": " + item.Value);
                     }
                 }
             }
             catch (IOException ex)
             {
                 Console.Write(ex.Message);
             }*/


            //Seção 14 - aula 161 - Extension methods

            //São métodos que estendem a funcionalidade de um tipo, sem alterar ou herdar esse tipo

            /*DateTime dt = new DateTime(2025, 11, 14, 8, 10, 45);
            //Esse método não existe dentro da classe DateTIme, mas eu vou criar
            Console.WriteLine(dt.ElapsedTime()); //não preciso passar nada, o this que recebo lá dentro é uma referencia ao próprio objeto

            String st = "Good morning dear students!";
            Console.Write(st.Cut(10));*/

            //Seçãp 15 - aula 163 Comparison
            // Se eu uso IComparable na minha classe Product ela nai fica fechada para alteração, caso eu precise mudar o tipo de comparação, por exemplo.
            // Existe a opção de eu usar uma sobrecarga do Sort para resolver Sort(Comparison<T> comparison)
            //public delegate int Comparison<in T>(T x, T y);

            /* List<Product> list = new List<Product>();

             list.Add(new Product("TV", 900));
             list.Add(new Product("Notebook", 1200));
             list.Add(new Product("Table", 450));

             // escolho a carga do sort que recebe um Comparison
             static int CompareProducts(Product p1, Product p2)
             {
                 return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
             }
             Comparison<Product> comp = CompareProducts;
             list.Sort(comp);

             //Posso simplificar isso com uma expressão lambda
             list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

             //Agora eu posso ter diferentes formas de ordenar, posso fazer um pelo preço, por exemplo.
             foreach (Product p in list)
             {
                 Console.WriteLine(p);
             }*/

            //Seção 15 - aula 164 - Programação funcional e cálculo lambda, Multicast delegate

            /*double a = 10;
            double b = 12;

            // double result = CalculationService2.Sum(a, b);
            // ao invés de chamar o serviço, possi chamar o delegate, uma função que recebe outra como parâmetro.s
            // op += CalculationService.ShowMax; posso usar multicast, fazendo com que várias funções sejam executadas em sequencia. Faz sentido para método void.
            BinaryNumericOperation op = CalculationService2.Sum;
            Console.WriteLine(op(a,b));*/

            //Seção 15 - aula 167 - Predicate
            // Nesse caso sempre volta um booleano

            /* List<Product> list = new List<Product>();
             list.Add(new Product("Tv", 900.00));
             list.Add(new Product("Mouse", 50.00));
             list.Add(new Product("Tablet", 350.50));
             list.Add(new Product("HD Case", 80.90));

             list.RemoveAll(p => p.Price >= 100.0);//espera um predicate
             foreach (Product p in list)
             {
                 Console.WriteLine(p);
             }*/

            // Seção 15 - Action - aula 168
            // O forEach espera um Action, uma função do tipo void

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }








        }

        // faço uma funão auxiliar, para imprimir
        // o tipo IEnumerable é nativo do C#, tenho o getEnumerator dentro dele que permite com que eu percorra a coleção
        // é uma padrão de projetos para eu percorrer uma coleção de forma padronizada

        //é uma coleção do tipo T que implementa o IEnumerable
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}