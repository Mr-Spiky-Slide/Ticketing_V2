class Ticket
{
    //Properties
    public int TicketID { get; set; }
    public string Summary { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    public string Assigned { get; set; }
    public string Submitter { get; set; }
    public List<string> Watching = new List<String>();

}