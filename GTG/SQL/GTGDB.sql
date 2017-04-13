/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      SQL2014
 * Project :      Project01.DM1
 * Author :       ÎÞÀµ
 *
 * Date Created : Wednesday, April 12, 2017 11:45:22
 * Target DBMS : Microsoft SQL Server 2008
 */

/* 
 * TABLE: Admin 
 */

CREATE TABLE Admin(
    AID         int             IDENTITY(1,1),
    WID         int             NOT NULL,
    LoginId     nchar(20)       NOT NULL,
    LoginPWD    nchar(20)       NULL,
    AName       nvarchar(12)    NOT NULL,
    ASex        char(4)         NOT NULL,
    ACardID     varchar(18)     NOT NULL,
    APhone      varchar(20)     NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (AID)
)
go



IF OBJECT_ID('Admin') IS NOT NULL
    PRINT '<<< CREATED TABLE Admin >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Admin >>>'
go

/* 
 * TABLE: BillOfLading 
 */

CREATE TABLE BillOfLading(
    BID      int         IDENTITY(1,1),
    WID      int         NOT NULL,
    SID      int         NOT NULL,
    BDate    datetime    DEFAULT Getdate() NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (BID)
)
go



IF OBJECT_ID('BillOfLading') IS NOT NULL
    PRINT '<<< CREATED TABLE BillOfLading >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE BillOfLading >>>'
go

/* 
 * TABLE: BillOfLadingDetail 
 */

CREATE TABLE BillOfLadingDetail(
    BLDID     int    IDENTITY(1,1),
    BID       int    NOT NULL,
    GID       int    NOT NULL,
    BLDNum    int    NOT NULL,
    CONSTRAINT PK16 PRIMARY KEY NONCLUSTERED (BLDID)
)
go



IF OBJECT_ID('BillOfLadingDetail') IS NOT NULL
    PRINT '<<< CREATED TABLE BillOfLadingDetail >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE BillOfLadingDetail >>>'
go

/* 
 * TABLE: CLerk 
 */

CREATE TABLE CLerk(
    CID        int             IDENTITY(1,1),
    SID        int             NOT NULL,
    CName      nvarchar(12)    NOT NULL,
    CSex       char(4)         DEFAULT 1 NOT NULL,
    CCardID    varchar(18)     NOT NULL,
    CPhone     varchar(20)     NULL,
    CONSTRAINT PK1_2 PRIMARY KEY NONCLUSTERED (CID)
)
go



IF OBJECT_ID('CLerk') IS NOT NULL
    PRINT '<<< CREATED TABLE CLerk >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE CLerk >>>'
go

/* 
 * TABLE: Client 
 */

CREATE TABLE Client(
    CTID         int             IDENTITY(1,1),
    CTname       nvarchar(12)    NOT NULL,
    CTaddress    nvarchar(25)    NOT NULL,
    CTPhone      varchar(20)     NULL,
    CONSTRAINT PK3_2 PRIMARY KEY NONCLUSTERED (CTID)
)
go



IF OBJECT_ID('Client') IS NOT NULL
    PRINT '<<< CREATED TABLE Client >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Client >>>'
go

/* 
 * TABLE: DeliveryNote 
 */

CREATE TABLE DeliveryNote(
    DID     int    IDENTITY(1,1),
    SPID    int    NOT NULL,
    GID     int    NOT NULL,
    DNum    int    NOT NULL,
    CONSTRAINT PK5_1 PRIMARY KEY NONCLUSTERED (DID)
)
go



IF OBJECT_ID('DeliveryNote') IS NOT NULL
    PRINT '<<< CREATED TABLE DeliveryNote >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE DeliveryNote >>>'
go

/* 
 * TABLE: Goods 
 */

CREATE TABLE Goods(
    GID          int             IDENTITY(1,1),
    GName        nvarchar(12)    NOT NULL,
    GNum         int             NOT NULL,
    GStyle       nvarchar(10)    NOT NULL,
    GStandard    nvarchar(12)    NOT NULL,
    GUnit        varchar(5)      NOT NULL,
    CONSTRAINT PK3_1 PRIMARY KEY NONCLUSTERED (GID)
)
go



IF OBJECT_ID('Goods') IS NOT NULL
    PRINT '<<< CREATED TABLE Goods >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Goods >>>'
go

/* 
 * TABLE: PurchaseList 
 */

CREATE TABLE PurchaseList(
    PID        int         IDENTITY(1,1),
    WID        int         NOT NULL,
    PInDate    datetime    NOT NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (PID)
)
go



IF OBJECT_ID('PurchaseList') IS NOT NULL
    PRINT '<<< CREATED TABLE PurchaseList >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE PurchaseList >>>'
go

/* 
 * TABLE: PurchaseListDetail 
 */

CREATE TABLE PurchaseListDetail(
    PLDID     int    IDENTITY(1,1),
    PID       int    NOT NULL,
    GID       int    NOT NULL,
    PLDNum    int    NOT NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (PLDID)
)
go



IF OBJECT_ID('PurchaseListDetail') IS NOT NULL
    PRINT '<<< CREATED TABLE PurchaseListDetail >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE PurchaseListDetail >>>'
go

/* 
 * TABLE: Saledetail 
 */

CREATE TABLE Saledetail(
    SDID     int    IDENTITY(1,1),
    STID     int    NOT NULL,
    GID      int    NOT NULL,
    SDNum    int    NOT NULL,
    CONSTRAINT PK1_1 PRIMARY KEY NONCLUSTERED (SDID)
)
go



IF OBJECT_ID('Saledetail') IS NOT NULL
    PRINT '<<< CREATED TABLE Saledetail >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Saledetail >>>'
go

/* 
 * TABLE: SalesStore 
 */

CREATE TABLE SalesStore(
    SID             int             IDENTITY(1,1),
    SName           nvarchar(12)    NOT NULL,
    SAddrsse        nvarchar(25)    NOT NULL,
    SManagerName    nvarchar(12)    NOT NULL,
    SPhone          varchar(20)     NULL,
    CONSTRAINT PK2_1 PRIMARY KEY NONCLUSTERED (SID)
)
go



IF OBJECT_ID('SalesStore') IS NOT NULL
    PRINT '<<< CREATED TABLE SalesStore >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE SalesStore >>>'
go

/* 
 * TABLE: SalesTicket 
 */

CREATE TABLE SalesTicket(
    STID      int         IDENTITY(1,1),
    SID       int         NOT NULL,
    CTID      int         NOT NULL,
    STDate    datetime    NOT NULL,
    CONSTRAINT PK4_2 PRIMARY KEY NONCLUSTERED (STID)
)
go



IF OBJECT_ID('SalesTicket') IS NOT NULL
    PRINT '<<< CREATED TABLE SalesTicket >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE SalesTicket >>>'
go

/* 
 * TABLE: Supplier 
 */

CREATE TABLE Supplier(
    SPID       int             IDENTITY(1,1),
    SPName     nvarchar(12)    NOT NULL,
    SPMan      nvarchar(12)    NOT NULL,
    SPPhone    varchar(20)     NULL,
    CONSTRAINT PK4_1 PRIMARY KEY NONCLUSTERED (SPID)
)
go



IF OBJECT_ID('Supplier') IS NOT NULL
    PRINT '<<< CREATED TABLE Supplier >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Supplier >>>'
go

/* 
 * TABLE: Warehouse 
 */

CREATE TABLE Warehouse(
    WID         int             IDENTITY(1,1),
    WName       nvarchar(12)    NOT NULL,
    WAddress    nvarchar(25)    NOT NULL,
    WExplain    nvarchar(50)    NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (WID)
)
go



IF OBJECT_ID('Warehouse') IS NOT NULL
    PRINT '<<< CREATED TABLE Warehouse >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Warehouse >>>'
go

/* 
 * TABLE: WarehouseList 
 */

CREATE TABLE WarehouseList(
    WLID      int         IDENTITY(1,1),
    WID       int         NOT NULL,
    WLDate    datetime    DEFAULT Getdate() NOT NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (WLID)
)
go



IF OBJECT_ID('WarehouseList') IS NOT NULL
    PRINT '<<< CREATED TABLE WarehouseList >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE WarehouseList >>>'
go

/* 
 * TABLE: WarehouseListDetail 
 */

CREATE TABLE WarehouseListDetail(
    WLDID     int    IDENTITY(1,1),
    WLID      int    NOT NULL,
    GID       int    NOT NULL,
    WLDNum    int    NOT NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (WLDID)
)
go



IF OBJECT_ID('WarehouseListDetail') IS NOT NULL
    PRINT '<<< CREATED TABLE WarehouseListDetail >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE WarehouseListDetail >>>'
go

/* 
 * TABLE: Admin 
 */

ALTER TABLE Admin ADD CONSTRAINT RefWarehouse7 
    FOREIGN KEY (WID)
    REFERENCES Warehouse(WID)
go


/* 
 * TABLE: BillOfLading 
 */

ALTER TABLE BillOfLading ADD CONSTRAINT RefWarehouse9 
    FOREIGN KEY (WID)
    REFERENCES Warehouse(WID)
go

ALTER TABLE BillOfLading ADD CONSTRAINT RefSalesStore30 
    FOREIGN KEY (SID)
    REFERENCES SalesStore(SID)
go


/* 
 * TABLE: BillOfLadingDetail 
 */

ALTER TABLE BillOfLadingDetail ADD CONSTRAINT RefGoods55 
    FOREIGN KEY (GID)
    REFERENCES Goods(GID)
go

ALTER TABLE BillOfLadingDetail ADD CONSTRAINT RefBillOfLading57 
    FOREIGN KEY (BID)
    REFERENCES BillOfLading(BID)
go


/* 
 * TABLE: CLerk 
 */

ALTER TABLE CLerk ADD CONSTRAINT RefSalesStore34 
    FOREIGN KEY (SID)
    REFERENCES SalesStore(SID)
go


/* 
 * TABLE: DeliveryNote 
 */

ALTER TABLE DeliveryNote ADD CONSTRAINT RefGoods52 
    FOREIGN KEY (GID)
    REFERENCES Goods(GID)
go

ALTER TABLE DeliveryNote ADD CONSTRAINT RefSupplier18 
    FOREIGN KEY (SPID)
    REFERENCES Supplier(SPID)
go


/* 
 * TABLE: PurchaseList 
 */

ALTER TABLE PurchaseList ADD CONSTRAINT RefWarehouse11 
    FOREIGN KEY (WID)
    REFERENCES Warehouse(WID)
go


/* 
 * TABLE: PurchaseListDetail 
 */

ALTER TABLE PurchaseListDetail ADD CONSTRAINT RefPurchaseList49 
    FOREIGN KEY (PID)
    REFERENCES PurchaseList(PID)
go

ALTER TABLE PurchaseListDetail ADD CONSTRAINT RefGoods50 
    FOREIGN KEY (GID)
    REFERENCES Goods(GID)
go


/* 
 * TABLE: Saledetail 
 */

ALTER TABLE Saledetail ADD CONSTRAINT RefGoods58 
    FOREIGN KEY (GID)
    REFERENCES Goods(GID)
go

ALTER TABLE Saledetail ADD CONSTRAINT RefSalesTicket59 
    FOREIGN KEY (STID)
    REFERENCES SalesTicket(STID)
go


/* 
 * TABLE: SalesTicket 
 */

ALTER TABLE SalesTicket ADD CONSTRAINT RefClient60 
    FOREIGN KEY (CTID)
    REFERENCES Client(CTID)
go

ALTER TABLE SalesTicket ADD CONSTRAINT RefSalesStore31 
    FOREIGN KEY (SID)
    REFERENCES SalesStore(SID)
go


/* 
 * TABLE: WarehouseList 
 */

ALTER TABLE WarehouseList ADD CONSTRAINT RefWarehouse10 
    FOREIGN KEY (WID)
    REFERENCES Warehouse(WID)
go


/* 
 * TABLE: WarehouseListDetail 
 */

ALTER TABLE WarehouseListDetail ADD CONSTRAINT RefWarehouseList53 
    FOREIGN KEY (WLID)
    REFERENCES WarehouseList(WLID)
go

ALTER TABLE WarehouseListDetail ADD CONSTRAINT RefGoods54 
    FOREIGN KEY (GID)
    REFERENCES Goods(GID)
go


