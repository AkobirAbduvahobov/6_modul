﻿namespace GameStoreWebApp.Service.ResponseModels;

public class IBoxResponseDTO
{
    public Guid UserId { get; set; }
    public Guid OrderId { get; set; }
    public DateTime PaymentDate { get; set; }
    public double Sum { get; set; }
}
