using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerSupportMessage
{
    public int MessageId { get; set; }

    public int? TicketId { get; set; }

    public int? SenderId { get; set; }

    public int? ReceiverId { get; set; }

    public string? MessageContent { get; set; }

    public int? UnreadCount { get; set; }

    public string? AttachmentUrl { get; set; }

    public DateTime? SentTime { get; set; }

    public virtual CustomerSupportTicket? Ticket { get; set; }
}
