export interface Ticket {
    id: number
    solicitareId: number
    solicitare: Solicitare
    unitateId: number
    unitate: Unitate
    statusId: number
    status: Status
    serviciuId: number
    serviciu: Serviciu2
    idUserExpeditor: number
    emailSolicitant: string
    tlfnInteriorSolicitant: string
    tlfMobilSolicitant: string
    dataDeschidereTicket: string
    descriere: string
    idLucratorAsignat: number
    valid: boolean
  }
  
  export interface Solicitare {
    id: number
    denumire: string
    serviciuAsignatId: number
    serviciu: Serviciu
    valid: boolean
  }
  
  export interface Serviciu {
    id: number
    denumire: string
    prescurtare: string
    valid: boolean
  }
  
  export interface Unitate {
    id: number
    denumire: string
    prescurtare: string
    valid: boolean
  }
  
  export interface Status {
    id: number
    denumire: string
  }
  
  export interface Serviciu2 {
    id: number
    denumire: string
    prescurtare: string
    valid: boolean
  }
  