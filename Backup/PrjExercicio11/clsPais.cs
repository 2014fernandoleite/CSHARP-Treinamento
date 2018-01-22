using System.Xml.Serialization;

[XmlRoot(ElementName = "clsPais")]
public class clsPais
{
    private int INT_CdPais;
    private string STR_DsPais;

    [XmlElement(ElementName = "CdPais")]
    public int CdPais
    {
        get { return INT_CdPais; }
        set { INT_CdPais = value; }
    }

    [XmlElement(ElementName = "DsPais")]
    public string DsPais
    {
        get { return STR_DsPais; }
        set { STR_DsPais = value; }
    }
}