Console.Write("Bienvenido, crearemos un árbol binario. \nIngrese el valor raíz del primer árbol: ");
int rootValue = int.Parse(Console.ReadLine());

BinaryTree tree = new BinaryTree();
tree.AddNodo(rootValue);

while (true)
{
    Console.Write("Ingrese un nuevo valor para añadir al árbol binario ('salir' para terminar la ejecución): ");
    var input = Console.ReadLine();
    if (input.ToLower() == "salir") break;

    int value;
    if (int.TryParse(input, out value))
    {
        tree.AddNodo(value);
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un número válido.");
    }
}

int sumTree = tree.SumNodes();
Console.WriteLine("La suma es " + sumTree);
double averageTree = tree.AverageNodes();
Console.WriteLine("El promedio es: " + averageTree);
int TotalHeigth = tree.TotalHeightTree();
Console.WriteLine("La altura es: " + TotalHeigth);


class Nodo
{
    public int value { get; set; }
    public Nodo left { get; set; }
    public Nodo right { get; set; }

    public Nodo(int value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}


class BinaryTree
{
    private Nodo root;

    public BinaryTree()
    {
        this.root = null;
    }

    public void AddNodo(int value)
    {
        Nodo node = new Nodo(value);
        if (this.root != null)
        {
            this.AddNewNodo(this.root, node);
            return;
        }
        this.root = node;
    }

    private void AddNewNodo(Nodo rootNode, Nodo newNode)
    {
        if (rootNode.left == null)
        {
            rootNode.left = newNode;
            return;
        }

        if (rootNode.right == null)
        {
            rootNode.right = newNode;
            return;
        }

        this.AddNewNodo(rootNode.left, newNode);
        return;
    }


    public int SumNodes()
    {
        return SumTotalNodes(this.root);
    }
    private int SumTotalNodes(Nodo nodo)
    {
        if (nodo == null)
        {
            return 0;
        }
        return nodo.value + SumTotalNodes(nodo.left) + SumTotalNodes(nodo.right);
    }
    public int TotalNodes()
    {
        return this.CountNodes(this.root);
    }

    private int CountNodes(Nodo nodo)
    {
        if (nodo == null)
        {
            return 0;
        }
        return 1 + CountNodes(nodo.left) + CountNodes(nodo.right);
    }

    public double AverageNodes()
    {
        if (this.root == null)
        {
            return 0;
        }

        int sum = SumTotalNodes(this.root);
        int count = CountNodes(this.root);

        return (double)sum / count;
    }

    private int HeightTree(Nodo nodo)
    {
        if (nodo == null)
        {
            return 0;
        }

        return Math.Max(this.HeightTree(nodo.left), this.HeightTree(nodo.right)) + 1;
    }

    public int TotalHeightTree()
    {
        return this.HeightTree(this.root);
    }

}



