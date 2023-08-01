public interface ICreditCard
{
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
}

public class MoneyBackCreditCard : ICreditCard
{
    public string GetCardType()
    {
        return "MoneyBack";
    }

    public int GetCreditLimit()
    {
        return 15000;
    }

    public int GetAnnualCharge()
    {
        return 500;
    }
}

public class TitaniumCreditCard : ICreditCard
{
    public string GetCardType()
    {
        return "Titanium";
    }

    public int GetCreditLimit()
    {
        return 25000;
    }

    public int GetAnnualCharge()
    {
        return 1500;
    }
}

public class PlatinumCreditCard : ICreditCard
{
    public string GetCardType()
    {
        return "Platinum";
    }

    public int GetCreditLimit()
    {
        return 35000;
    }

    public int GetAnnualCharge()
    {
        return 2000;
    }
}

public class CreditCardFactory
{
    public static ICreditCard GetCreditCard(string cardType)
    {
        ICreditCard cardDetails = null;

        if (cardType == "MoneyBack")
        {
            cardDetails = new MoneyBackCreditCard();
        }
        else if (cardType == "Titanium")
        {
            cardDetails = new TitaniumCreditCard();
        }
        else if (cardType == "Platinum")
        {
            cardDetails = new PlatinumCreditCard();
        }

        return cardDetails;
    }
}