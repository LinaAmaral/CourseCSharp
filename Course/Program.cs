using System.Globalization;
using System.Security;
using System.Security.Cryptography;
using Course.Entities;
using Course.Entities.Enums;
using System.IO;
using Course.Services;
using Course.Entities.Model;


namespace Course
{
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

            List<Produto> list = new List<Produto>();

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

            Console.WriteLine("Mais caro: " + produto);












        }
    }
}