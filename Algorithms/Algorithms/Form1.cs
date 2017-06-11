using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Algorithms : Form
    {
        public Graph.Graph demoGraph = new Graph.Graph();

        public Algorithms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Go button
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = input.Text;
            while (Queue.Items.Count > 0)
            {
                switch (Queue.Items[0])
                {
                    case "Echo":
                        break;
                    case "Remove Duplicate Letters":
                        temp = textAlgorithms.removeDupes(temp);
                        break;
                    case "To Lower Case":
                        temp = temp.ToLower();
                        break;
                }
                Queue.Items.Remove(Queue.Items[0]);
            }
            textOutput.Text = temp;

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Queue.Items.Add(Algorithm.SelectedItem);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            Queue.Items.Remove(Queue.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Makes sure we're selecting an origin node from the list
            if (graphNodes.SelectedItem == null)
            {
                return;
            }
            Graph.Node originNode = null;
            foreach (Graph.Node N in demoGraph.nodes)
            {
                if (N.name == graphNodes.SelectedItem.ToString())
                {
                    originNode = N;
                }
            }
            if (originNode == null)
            {
                return;
            }
            foreach (Graph.Arrow a in originNode.edges)
            {
                if (a.target.name == graphInput.Text)
                {
                    graphOutput.Text = "Only 1 edge between two nodes (I can remove this if need be...)";
                    return;
                }
            }
            int weight;
            if (edgeWeight.Text != "" && edgeWeight.Text.All(char.IsDigit))
            {
                weight = int.Parse(edgeWeight.Text);
            } else
            {
                weight = 1;
            }
            Graph.Arrow target = new Graph.Arrow();
            foreach (Graph.Node N in demoGraph.nodes)
            {
                if (N.name == graphInput.Text)
                {
                    target.target = N;
                    target.weight = weight;
                }
            }
            if (target.target == null)
            {
                return;
            }
            originNode.edges.Add(target);
            graphEdges.Items.Add(target.target.name + " (" + target.weight + ")");
            if (undirected.Checked)
            {
                Graph.Arrow otherWay = new Graph.Arrow();
                otherWay.target = originNode;
                otherWay.weight = weight;
                target.target.edges.Add(otherWay);

            }
            undirected.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            demoGraph = new Graph.Graph();
            graphNodes.Items.Clear();
            graphEdges.Items.Clear();
            undirected.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textAlgorithms.containsWhitespace(graphInput.Text))
            {
                return;
            }
            Graph.Node newNode = new Graph.Node();
            newNode.name = graphInput.Text;
            if (demoGraph.nodes != null)
            {
                foreach (Graph.Node N in demoGraph.nodes)
                {
                    if (N.name == newNode.name)
                    {
                        return;
                    }
                }
            }
            demoGraph.nodes.Add(newNode);
            graphNodes.Items.Add(graphInput.Text);
            graphInput.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (demoGraph.nodes.Count < 2)
            {
                graphOutput.Text = "Please add at least 2 nodes.";
                return;
            }
            Graph.Node start = null;
            Graph.Node end = null;
            foreach (Graph.Node n in demoGraph.nodes)
            {
                if (n.name == graphStartNode.Text)
                {
                    start = n;
                }
                if (n.name == graphEndNode.Text){
                    end = n;
                }
            }
            if (start == null || end == null)
            {
                graphOutput.Text = "Please enter valid start and end nodes.";
                return;
            }

            Graph.Path answer = Graph.Graph.dijkstra(demoGraph, start, end);
            if (answer.path.Count <= 1)
            {
                graphOutput.Text = "No valid path found.";
                return;
            }
            string output = "Cost: " + answer.cost.ToString() + ". Path: ";
            foreach (Graph.Node n in answer.path)
            {
                output += n.name + ", ";
            }
            output = output.Remove(output.Length - 2);
            graphOutput.Text = output;
        }

        private void graphEdges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void graphNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            graphEdges.Items.Clear();
            Graph.Node current = null;
            foreach (Graph.Node N in demoGraph.nodes)
            {
                if (N.name == graphNodes.SelectedItem.ToString())
                {
                    current = N;
                }
            }
            foreach(Graph.Arrow N in current.edges)
            {
                graphEdges.Items.Add(N.target.name + " (" + N.weight + ")");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void graphInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace Graph
{
    public class Node
    {
        public string name;
        public List<Arrow> edges = new List<Arrow>();
        public int distance;
        public Node parent;
    }

    public class Arrow
    {
        public Node target;
        public int weight;
    }

    public class Path
    {
        public int cost;
        public List<Node> path;
    }

    public class Graph
    {
        public List<Node> nodes = new List<Node>();
        static public Path dijkstra(Graph map, Node start, Node end)
        {
            List<Node> unvisited = new List<Node>();
            foreach(Node n in map.nodes)
            {
                if (n != start)
                {
                    n.distance = -1;
                    unvisited.Add(n);
                }
            }
            if (unvisited.Contains(end))
            {
                Console.WriteLine("Working");
            }
            bool finished = false;
            Node current = start;

            // set distances
            while (!finished)
            {
                Console.WriteLine(current.name + " - " + current.distance);
                foreach (Arrow A in current.edges)
                {
                    if (A.target.distance == -1 || A.target.distance > current.distance + A.weight){
                        A.target.distance = current.distance + A.weight;
                        A.target.parent = current;
                    }
                }

                current = null;
                foreach (Node n in unvisited)
                {
                    if (current == null || current.distance == -1 || (n.distance != -1 && n.distance < current.distance)){
                        current = n;
                    }
                }
                Console.WriteLine(current.name);
                unvisited.Remove(current);


                // exit condition
                if (!unvisited.Contains(end))
                {
                    finished = true;
                }
            }

            Path answer = new Path();
            answer.cost = end.distance;
            answer.path = new List<Node>();
            answer.path.Add(end);
            if (end.parent != null)
            {
                while (!answer.path.Contains(start))
                {
                    answer.path.Add(answer.path.Last<Node>().parent);
                }
            }
            answer.path.Reverse();
            return answer;
        }
    }
    
}



public static class textAlgorithms
{
    public static string removeDupes(string start)
    {
        string result = "";
        foreach (char value in start)
        {
            if (result.IndexOf(value) == -1)
            {
                result += value;
            }
        }
        return result;
    }

    public static bool containsWhitespace(string s)
    {
        return s.Any(Char.IsWhiteSpace);
    }
}