// See https://aka.ms/new-console-template for more information
using QueraQuestions.CodeCup8;

//var graph = new List<GraphNodes>
//{
//    new GraphNodes
//    {
//        Id = 1,
//        IsRoot = true,
//        Neighbors = new List<int> { 7 }
//    },new GraphNodes
//    {
//        Id = 2,
//        IsRoot = true,
//        Neighbors = new List<int> { 7 }
//    },new GraphNodes
//    {
//        Id = 3,
//        IsRoot = true,
//        Neighbors = new List<int> { 7 }
//    },new GraphNodes
//    {
//        Id = 6,
//        IsRoot = true,
//        Neighbors = new List<int> { 4 }
//    },new GraphNodes
//    {
//        Id = 5,
//        IsRoot = true,
//        Neighbors = new List<int> { 4 }
//    },new GraphNodes
//    {
//        Id = 8,
//        IsRoot = true,
//        Neighbors = new List<int> { 4 }
//    }
//    ,new GraphNodes
//    {
//        Id = 4,
//        IsRoot = false,
//        Neighbors = new List<int> { 8,5,6,7 }
//    },new GraphNodes
//    {
//        Id = 7,
//        IsRoot = false,
//        Neighbors = new List<int> { 1,2,3,4 }
//    }
//};
//var obj = new GovernorPrize(graph);
//Console.WriteLine(obj.Compute().ToString());
//Console.Read();




int totalNodes = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= totalNodes; i++)
{
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        var splitedInput = input.Trim().Split(" ");
        foreach (var item in splitedInput)
        {

        }
        var obj = new GraphNodes { Id = i, IsRoot = false, Neighbors =  };
    }

}
