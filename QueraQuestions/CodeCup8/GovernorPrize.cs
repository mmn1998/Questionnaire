namespace QueraQuestions.CodeCup8;

public class GovernorPrize
{
    private readonly List<GraphNodes> _nodes;
    public GovernorPrize(List<GraphNodes> nodes)
    {
        _nodes = nodes;
    }
    public int Compute()
    {
        int result = 0;
        int minimumPrizeForNotRoots = 2;
        foreach (var node in _nodes)
        {
            if (node.IsRoot)
            {
                result++;
                node.Prize = 1;
            }
            else
            {
                if (node.Neighbors is not null)
                {
                    foreach (var neighborId in node.Neighbors)
                    {
                        var neighbor = _nodes.First(x => x.Id == neighborId);
                        if (node.Neighbors.Contains(neighborId) && !neighbor.IsRoot && neighbor.Prize != 0)
                        {
                            minimumPrizeForNotRoots = minimumPrizeForNotRoots + 1;
                        }
                    }
                }
                result = result + minimumPrizeForNotRoots;
                node.Prize = minimumPrizeForNotRoots;
            }
        }
        return result;
    }
}
public class GraphNodes
{
    public int Id { get; set; }
    public bool IsRoot { get; set; }
    public int Prize { get; set; } = 0;
    public List<int>? Neighbors { get; set; }
}
