﻿using System;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

    static int getHeight(Node root){
        //Write your code here
        
        return root == null ? -1 : 1 + Math.Max(getHeight(root.left), getHeight(root.right));
       //another way
        /*if (root == null) {
            return - 1;
        }else{
            return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
        } */

        
        
    }

    static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        int height=getHeight(root);
        Console.WriteLine(height);
        
    }
}