using System.Diagnostics.CodeAnalysis;
using System.Transactions;

class Bin
{
    public string _denomination;
    private decimal _value;   //we'll be using this one instead of  a float or double because this has to do with money and decimal is more exact
    private int _count; //because this has to do with numebers, and uint would not allow negative values while int does


    // methods
    public Bin()  //the constructor is the same name as the class, this is a new bin object, the datatype is already the name of the function
    {
        _denomination = denomination;
        _value = value;
        _count = count;

    }

    public GetCount()
    {

        return count;
    }

    public int GetValue;
    {
        return value;
    }
    public void Transact(int delta)


}