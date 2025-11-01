
namespace Course.Entities
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }

    /*
    Em C#, struct é um tipo de valor que agrupa um conjunto de variáveis relacionadas em uma única unidade, diferente de uma classe, que é um tipo de referência. Structs são frequentemente usadas para representar dados pequenos e simples, como coordenadas (\(x,y\)) ou cores, e são mais leves em termos de alocação de memória porque não têm a mesma sobrecarga de referência que as classes. Elas podem ter campos, métodos e construtores, mas não podem herdar de outras structs ou classes. Características principais Tipo de valor: Structs são armazenadas na pilha ou no valor da própria variável, sendo copiadas quando são passadas para outras variáveis ou métodos.Desempenho: São mais leves e geralmente mais rápidas que classes, pois evitam o "garbage collector" (coletor de lixo) e a sobrecarga de referência. Isso as torna ideais para dados pequenos e usados com frequência.Agrupamento de dados: Permitem agrupar diferentes tipos de dados (como int, string, float) em um único tipo, facilitando a organização e o manuseio.Sem herança: Não suportam herança de outras structs ou classes.Acesso aos membros: O acesso aos membros (campos) é feito através do operador ponto (.), semelhante às classes. Ex: pessoa.Nome = "André";. C#: entendendo classes e structs - Alura20 de jun. de 2022 — Mas, afinal, o que são Structs? As structs, muito comuns na linguagem C, têm como objetivo estruturar alguns dad...AluraEstruturas C (structs) - W3SchoolsConteúdo traduzido — Estruturas (também chamadas de structs) são uma maneira de agrupar diversas variáveis ​​relacionadas em um só lu...W3SchoolsO que é uma struct no C#? - Develop4Us8 de mar. de 2025 — Quando Usar struct no C#? ✅ Para representar dados pequenos e imutáveis, como coordenadas, cores, valores de temp...Develop4UsClasses, estruturas e registros - C# | Microsoft Learn20 de abr. de 2025 — Em C#, a definição de um tipo — uma classe, struct ou registro — é como um blueprint que especifica o que o tipo...Microsoft LearnQual a diferença entre Struct e Class? - Stack Overflow em Português16 de mai. de 2014 — Onde eles são usados. As structs existentes no . NET dão uma ideia de como estes tipos devem definir dados com u...Stack Overflow em PortuguêsProgramação C - StructsProgramação C - Structs. ... Structs, também conhecidas como Registros, definem tipos de dados que agrupam variáveis sob um mesmo ...PUCRSConheça os conceitos básicos do sistema de tipos C# - C#Um struct é um tipo de valor. Quando um struct é criado, a variável à qual o struct é atribuído contém os dados reais do struct. Q...Microsoft LearnC#: entendendo classes e structs - Alura20 de jun. de 2022 — Mas, afinal, o que são Structs? As structs, muito comuns na linguagem C, têm como objetivo estruturar alguns dad...AluraEstruturas C (structs) - W3SchoolsConteúdo traduzido — Estruturas (também chamadas de structs) são uma maneira de agrupar diversas variáveis ​​relacionadas em um só lu...W3SchoolsO que é uma struct no C#? - Develop4Us8 de mar. de 2025 — Quando Usar struct no C#? ✅ Para representar dados pequenos e imutáveis, como coordenadas, cores, valores de temp...Develop4UsMostrar tudo   Aprofunde seus conhecimentos com o Modo IAAs respostas da IA podem conter erros. Saiba maisFeedback positivoFeedback negativoAgradecemos a colaboração
    Seu feedback ajuda o Google a melhorar a IA e muito mais, mesmo quando a configuração "Atividade na Web e de apps" está desativada.Saiba mais.
    Acrescentar outras informaçõesInformar um problemaFechar
    */
}
