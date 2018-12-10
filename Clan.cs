using System.Runtime.Serialization;

[DataContract(Name="Clan")]
public class Clan
{
    [DataMember(Name="clanName")]
    public string ClanName { get; set; }
    [DataMember(Name="clanType")]
    public int ClanType { get; set; }
    [DataMember(Name="createdBy")]
    public int CreatedBy { get; set; }
    [DataMember(Name="dateCreated")]
    public string DateCreated { get; set; }
    [DataMember(Name="description")]
    public string Description { get; set; }
    [DataMember(Name="id")]
    public int Id { get; set; }
    [DataMember(Name="menu1")]
    public string Menu1 { get; set; }
    [DataMember(Name="menu2")]
    public string Menu2 { get; set; }
    [DataMember(Name="parentClan")]
    public int ParentClan { get; set; }
    [DataMember(Name="passCode")]
    public string PassCode { get; set; }
    [DataMember(Name="status")]
    public int Status { get; set; }
}