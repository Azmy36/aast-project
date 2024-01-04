using System;


public class CustomStack<T>
{

    private T[] stackArray; // array of stack
    private int count;      // counter
    private int capacity;       // size of array of stack

    public CustomStack(int size)    // constructor
    {

        capacity = size;        // initialize the capacity of the array of stack
        stackArray = new T[capacity];   // create the array
        count = 0;          // initialize the count to 0
    }

    // Add an item
    public void Add(T item)
    {

        if (count == capacity)  // checking before adding the item if the stack is full or not
        {

            Console.WriteLine("Stack overflow");
            return;

        }

        stackArray[count] = item;   // add item in the stack
        count++;            // increment counter after adding
    }


    // Delete (pop) an item
    public T Delete()
    {

        if (count == 0)     // making sure there is an item to delete
        {

            Console.WriteLine("Stack underflow");

            return default(T);
        }

        count--;            // decrement the counter
        return stackArray[count];   // delete the item from the stack
    }


    // Update an item at a given index
    public void Update(int index, T newItem)    // index - the item needs to be updated, newItem - new value
    {

        if (index < 0 || index >= count)    // checking the index is in the range or not
        {

            Console.WriteLine("Index out of range");

            return;         // Added return statement
        }

        stackArray[index] = newItem;    // updating the stack
    }


    // Traverse the stack
    public void Traverse(Action<T> print)   // Console.WriteLine is the action taken inside the loop
    {

        for (int i = 0; i < count; i++)

        {

            print(stackArray[i]);   // print all the items in the stack
        }
    }

    // Search for an item
    public int Search(T item)   // T is the parameter of the method (item)
    {

        for (int i = 0; i < count; i++)

        {

            if (stackArray[i].Equals(item)) // search for the item
            {

                return i;       // return index of the item
            }

        }

        return -1;          // Item not found
    }


    // Find the length of the stack
    public int FindLength()
    {

        return count;

    }

}



class Program
{

    static void Main()
    {

        Console.WriteLine("Enter the size of the stack:");

        int size = Convert.ToInt32(Console.ReadLine());

        CustomStack<int> myStack = new CustomStack<int>(size);


        while (true)

        {

            Console.WriteLine("\nChoose an operation:");

            Console.WriteLine("1 - Add (Push)");

            Console.WriteLine("2 - Delete (Pop)");

            Console.WriteLine("3 - Update");

            Console.WriteLine("4 - Traverse and Display");

            Console.WriteLine("5 - Search");

            Console.WriteLine("6 - Find Length");

            Console.WriteLine("7 - Exit");

            Console.Write("Enter your choice: ");


            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)

            {

                case 1:

                    Console.Write("Enter the integer to add: ");

                    int item = Convert.ToInt32(Console.ReadLine());

                    myStack.Add(item);

                    break;

                case 2:
                    int deletedItem = myStack.Delete();


                    if (deletedItem != 0)

                    {

                        Console.WriteLine("Deleted item: " + deletedItem);

                    }

                    else

                    {

                        Console.WriteLine("No item to delete.");

                    }

                    break;


                case 3:

                    Console.Write("Enter index to update: ");

                    int index = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter new value: ");

                    int newValue = Convert.ToInt32(Console.ReadLine());

                    myStack.Update(index, newValue);

                    break;

                case 4:

                    myStack.Traverse(Console.WriteLine);

                    break;

                case 5:

                    Console.Write("Enter the value to search for: ");

                    int searchValue = Convert.ToInt32(Console.ReadLine());

                    int position = myStack.Search(searchValue);


                    if (position >= 0)

                    {

                        Console.WriteLine("Item found at position: " + position);

                    }

                    else

                    {

                        Console.WriteLine("Item not found.");

                    }

                    break;


                case 6:

                    Console.WriteLine("Current stack length: " +
                               myStack.FindLength());

                    break;

                case 7:

                    return;

                default:

                    Console.WriteLine("Invalid choice. Please try again.");

                    break;

            }

        }

    }

}