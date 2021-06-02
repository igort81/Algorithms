using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public static class BreadthFirstSearch
    {
        public static string DoBFS(Dictionary<string, List<string>> graph) {
            Queue<string> searchQueue = new Queue<string>();
            List<string> alreadySearched = new List<string>();
            foreach (var neighbour in graph["startnode"])
            {
                searchQueue.Enqueue(neighbour);
            }
            while (searchQueue.Count>0)
            {
                var node = searchQueue.Dequeue();
                if (node.Contains("Mango seller"))
                {
                    return node;
                }
                else
                {
                    if (!alreadySearched.Contains(node))
                    {
                        alreadySearched.Add(node);
                        if (graph[node]?.Count > 0)
                        {
                            foreach (var neighbour in graph[node])
                            {
                                searchQueue.Enqueue(neighbour);
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
