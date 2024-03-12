export interface EquityCalCulator {
  SellingPrice: number;
  ReservationDate: string;
  EquityTerm: number;
}

export interface EquitySchedule {
  id: number;
  balance: number;
  dueDate: string;
  term: number;
  paymentInfo: PaymentInfo[];
}

export interface PaymentInfo {
  id: number;
  amount: number;
  interest: number;
  insurance: number;
  total: number;
}
