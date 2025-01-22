using Binary_Tree;

BST bST = new BST(BST.InsertMethods.ITERATIVE);
bST.Insert(10);
bST.Insert(20);
bST.Insert(30);
bST.Insert(5);
bST.Insert(6);
bST.Insert(7);
bST.Insert(25);
bST.Print(BST.TraversalOrder.IN);

//OUTPUT = 5 6 7 10 20 25 30