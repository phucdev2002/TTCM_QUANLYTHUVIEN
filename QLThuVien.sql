--drop database QLThuVien
create database QLThuVien
go
use QLThuVien
go

-----
--drop table DOCGIA
create table DOCGIA
(
	MaDocGia nchar(10),
	HoTen nchar(30),
	GioiTinh nchar(5),
	NamSinh date,
	DiaChi nvarchar(100),
	PRIMARY KEY (MaDocGia),
)
--drop table SACH
create table SACH
(
	MaSach nchar(10),
	TenSach nchar(50),
	TacGia nchar(30),
	TheLoai nchar(30),
	NhaXuatBan nchar(50),
	GiaSach int,
	SoLuong int,
	TinhTrang nchar(10),
	PRIMARY KEY (MaSach),
)
--drop table PHIEUMUON
create table PHIEUMUON
(
	MaPhieu nchar(10),
	MaDocGia nchar(10),
	MaSach nchar(10),
	NgayMuon date,
	NgayPhaiTra date,
	PRIMARY KEY (MaPhieu),
)
--drop table PHIEUTRA
create table PHIEUTRA
(
	MaPhieu nchar(10),
	MaDocGia nchar(10),
	MaSach nchar(10),
	NgayTra date,
	PRIMARY KEY (MaPhieu),
)
--drop table ACCOUNT
create table ACCOUNT
(
	MaDocGia nchar(10) PRIMARY KEY,
	TenDangNhap nchar(30),
	MatKhau nchar(30),
	Quyen int,
)
--drop table DANGKYMUON
create table DANGKYMUON
(
	MaDocGia nchar(10),
	MaSach nchar(10),
	TenSach nchar(50),
	NgayMuon date,
	NgayPhaiTra date,
)


alter table DANGKYMUON add
	constraint FK_DANGKYMUON_DOCGIA foreign key(MaDocGia) references DOCGIA(MaDocGia),
	constraint FK_DANGKYMUON_SACH foreign key(MaSach) references SACH(MaSach)

alter table PHIEUMUON add
	constraint FK_PHIEUMUON_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGia),
	constraint FK_PHIEUMUON_SACH foreign key (MaSach) references SACH (MaSach)

alter table PHIEUTRA add
	constraint FK_PHIEUTRA_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGia),
	constraint FK_PHIEUTRA_SACH foreign key (MaSach) references SACH (MaSach)

ALTER TABLE dbo.DOCGIA ADD
	CONSTRAINT FK_DOCGIA_ACCOUNT FOREIGN KEY (MaDocGia) REFERENCES dbo.ACCOUNT(MaDocGia)


insert into ACCOUNT values ('DG0001','nguyenbamanh', '123456', 1)
insert into ACCOUNT values ('DG0002','chauthisuong', '123456', 1)
insert into ACCOUNT values ('DG0003','phamhaingoc', '123456', 1)
insert into ACCOUNT values ('DG0004','tranquangthang', '123456', 1)
insert into ACCOUNT values ('DG0005','nguyenphong', '123456', 1)
insert into ACCOUNT values ('DG0006','nguyenphuc', '123456', 1)
insert into ACCOUNT values ('DG0007','trungnguyen', '123456', 1)
insert into ACCOUNT values ('AD01','admin1', '1111', 0)
insert into ACCOUNT values ('AD02','admin2', '2222', 0)
----
insert into DOCGIA values ('DG0001',N'Nguyễn Bá Mạnh','Nam','2002-02-20',N'385 Trường Chinh, TP Tuy Hòa, Phú Yên')
insert into DOCGIA values ('DG0002',N'Châu Thị Sương','Nu','2003-03-22',N'961 Hậu Giang, P.11, Q.6, TPHCM')
insert into DOCGIA values ('DG0003',N'Phạm Hải Ngọc','Nam','2002-07-14',N'83/5 Trương Đăng Qué, Gò Vấp, TP HCM')
insert into DOCGIA values ('DG0004',N'Trần Quang Thắng',N'Nam','2000-02-27',N'128b/ 13 Tân Hòa Đông, P.14, Q.6, TPHCM')
insert into DOCGIA values ('DG0005',N'Nguyễn Minh Phong',N'Nam','2004-07-7',N'6/12 Nguyễn Siêu, P.Bến Nghé, TPHCM')
insert into DOCGIA values ('DG0006',N'Nguyễn Minh Phúc',N'Nam','2002-02-20',N'92 Trần Hưng Đạo, Ngô Mây')
insert into DOCGIA values ('DG0007',N'Lê Trung Nguyen',N'Nam','2000-07-21',N'148 Lê Đức Thọ, P.5, Gò Vấp')


----
insert into SACH values ('S0001', N'Lập trình hướng đối tượng', N'Không biết', N'Lập trình', 'UCT2', 150000, 3, N'Còn')
insert into SACH values ('S0002', N'Nhập môn lập trình', N'Không biết', N'Lập trình', 'UCT2', 1500000, 10, N'Còn')
insert into SACH values ('S0003', N'Kỹ thuật lập trình', N'Không biết', N'Lập trình', 'UCT2', 300000, 5, N'Còn')
insert into SACH values ('S0004', N'Thiết kế phần mềm', N'Không biết', N'Lập trình', 'UCT2', 250000, 0, N'Hết')
insert into SACH values ('S0005', N'Công nghệ đa phương tiện', N'Không biết', N'Công nghệ', 'UCT2', 500000, 25, N'Còn')
insert into SACH values ('S0006', N'Cuộc cách mạng học sâu', N'Không biết', N'Công nghệ', 'UCT2', 280000, 0, N'Hết')
insert into SACH values ('S0007', N'Thiết Kế Web', N'Không biết', N'Lập trình', 'UCT2', 250000, 1, N'Còn')
insert into SACH values ('S0008', N'Cấu trúc dữ liệu và giải thuật', N'Không biết', N'Lập trình', 'UCT2', 300000, 40, N'Còn')
insert into SACH values ('S0009', N'Mạng máy tính', N'Không biết', N'Lập trình', 'UCT2', 210000, 89, N'Còn')
insert into SACH values ('S0010', N'Lập trình thiết bị di động', N'Không biết', N'Lập trình', 'UCT2', 400000, 23, N'Còn')
insert into SACH values ('S0011', N'Tư tưởng Hồ Chí Minh', N'Không biết', N'Đại cương', 'UCT2', 100000, 200, N'Còn')
insert into SACH values ('S0012', N'Đại số tuyến tính', N'Không biết', N'Đại cương', 'UCT2', 50000, 70, N'Còn')
insert into SACH values ('S0013', N'Triết học', N'Không biết', N'Đại cương', 'UCT2', 70000, 305, N'Còn')
insert into SACH values ('S0014', N'Kỷ năng mềm', N'Không biết', N'Đại cương', 'UCT2', 50000, 267, N'Còn')

---
insert into PHIEUMUON values ('PM0001','DG0001','S0005','2023-06-14', '2023-06-16')
insert into PHIEUMUON values ('PM0002','DG0006','S0001','2023-06-28', '2023-07-06')
insert into PHIEUMUON values ('PM0003','DG0006','S0002','2023-06-28', '2023-07-06')

---
insert into PHIEUTRA values ('PT0001','DG0006','S0008','2023-06-16')


---
insert into DANGKYMUON values ('DG0002','S0001',N'Lập trình hướng đối tượng','2023-06-25', '2023-06-30')
insert into DANGKYMUON values ('DG0006','S0003',N'Kỹ thuật lập trình','2023-06-26', '2023-07-01')
insert into DANGKYMUON values ('DG0006','S0008',N'Cấu trúc dữ liệu và giải thuật','2023-06-28', '2023-07-03')
insert into DANGKYMUON values ('DG0002','S0005',N'Công nghệ đa phương tiện','2023-06-29', '2023-07-05')