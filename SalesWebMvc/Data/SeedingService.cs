using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
                return; //DB has been seeded
            else
            {
                Department d1 = new Department(1, "Computers");
                Department d2 = new Department(2, "Electronics");
                Department d3 = new Department(3, "Fashion");
                Department d4 = new Department(4, "Books");

                Seller s1 = new Seller(1, "Gabriel Ribeiro", "gjose.benevides@gmail.com", new DateTime(1998, 05, 08), 1000.0, d1);
                Seller s2 = new Seller(2, "Caroline Lacerda", "caroline@gmail.com", new DateTime(1999, 11, 03), 600.0, d3);
                Seller s3 = new Seller(3, "Mario Santos", "mario@gmail.com", new DateTime(1965, 12, 12), 7000.0, d2);
                Seller s4 = new Seller(4, "Cintia Ribeiro", "cintia@gmail.com", new DateTime(1969, 11, 17), 6000.0, d4);
                Seller s5 = new Seller(5, "Isis Santos", "isis@gmail.com", new DateTime(1994, 12, 03), 1200.0, d2);
                Seller s6 = new Seller(6, "Romulo Santos", "romulo@gmail.com", new DateTime(1992, 09, 20), 5000.0, d1);
                Seller s7 = new Seller(7, "Artur Ribeiro", "artur@gmail.com", new DateTime(2006, 05, 21), 300.0, d3);

                SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 01, 01), 11000.0, SaleStatus.Billed, s1);
                SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 01, 05), 1000.0, SaleStatus.Pending, s2);
                SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 01, 07), 15000.0, SaleStatus.Canceled, s3);
                SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 01, 16), 4000.0, SaleStatus.Billed, s4);
                SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 01, 19), 5000.0, SaleStatus.Billed, s5);
                SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 01, 20), 7000.0, SaleStatus.Billed, s6);
                SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 01, 23), 2600.0, SaleStatus.Canceled, s7);
                SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 01, 28), 5400.0, SaleStatus.Billed, s1);
                SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 01, 29), 600.0, SaleStatus.Canceled, s2);
                SalesRecord r10 = new SalesRecord(10, new DateTime(2020, 02, 02), 9000.0, SaleStatus.Pending, s3);
                SalesRecord r11 = new SalesRecord(11, new DateTime(2020, 02, 03), 8050.0, SaleStatus.Pending, s4);
                SalesRecord r12 = new SalesRecord(12, new DateTime(2020, 02, 05), 7500.0, SaleStatus.Pending, s5);
                SalesRecord r13 = new SalesRecord(13, new DateTime(2020, 02, 09), 8900.0, SaleStatus.Billed, s6);
                SalesRecord r14 = new SalesRecord(14, new DateTime(2020, 02, 11), 5400.0, SaleStatus.Canceled, s7);
                SalesRecord r15 = new SalesRecord(15, new DateTime(2020, 02, 15), 5620.0, SaleStatus.Pending, s1);
                SalesRecord r16 = new SalesRecord(16, new DateTime(2020, 02, 18), 4520.0, SaleStatus.Canceled, s2);
                SalesRecord r17 = new SalesRecord(17, new DateTime(2020, 02, 19), 7600.0, SaleStatus.Pending, s3);
                SalesRecord r18 = new SalesRecord(18, new DateTime(2020, 02, 21), 4500.0, SaleStatus.Billed, s4);
                SalesRecord r19 = new SalesRecord(19, new DateTime(2020, 02, 22), 4650.0, SaleStatus.Billed, s5);
                SalesRecord r20 = new SalesRecord(20, new DateTime(2020, 02, 25), 5412.0, SaleStatus.Billed, s6);
                SalesRecord r21 = new SalesRecord(21, new DateTime(2020, 02, 26), 45000.0, SaleStatus.Billed, s7);
                SalesRecord r22 = new SalesRecord(22, new DateTime(2020, 03, 01), 1000.0, SaleStatus.Pending, s1);
                SalesRecord r23 = new SalesRecord(23, new DateTime(2020, 03, 02), 1200.0, SaleStatus.Billed, s2);
                SalesRecord r24 = new SalesRecord(24, new DateTime(2020, 03, 02), 15600.0, SaleStatus.Pending, s3);
                SalesRecord r25 = new SalesRecord(25, new DateTime(2020, 03, 03), 1500.0, SaleStatus.Canceled, s4);
                SalesRecord r26 = new SalesRecord(26, new DateTime(2020, 03, 05), 15600.0, SaleStatus.Billed, s5);
                SalesRecord r27 = new SalesRecord(27, new DateTime(2020, 03, 06), 13000.0, SaleStatus.Canceled, s6);
                SalesRecord r28 = new SalesRecord(28, new DateTime(2020, 03, 15), 1600.0, SaleStatus.Pending, s7);
                SalesRecord r29 = new SalesRecord(29, new DateTime(2020, 03, 20), 900.0, SaleStatus.Billed, s1);
                SalesRecord r30 = new SalesRecord(30, new DateTime(2020, 03, 20), 5000.0, SaleStatus.Billed, s2);
                SalesRecord r31 = new SalesRecord(31, new DateTime(2020, 03, 22), 5400.0, SaleStatus.Billed, s3);
                SalesRecord r32 = new SalesRecord(32, new DateTime(2020, 03, 22), 6500.0, SaleStatus.Canceled, s4);
                SalesRecord r33 = new SalesRecord(33, new DateTime(2020, 03, 23), 560.0, SaleStatus.Canceled, s5);
                SalesRecord r34 = new SalesRecord(34, new DateTime(2020, 03, 23), 500.0, SaleStatus.Billed, s6);
                SalesRecord r35 = new SalesRecord(35, new DateTime(2020, 03, 23), 5600.0, SaleStatus.Pending, s7);
                SalesRecord r36 = new SalesRecord(36, new DateTime(2020, 03, 26), 1400.0, SaleStatus.Billed, s1);
                SalesRecord r37 = new SalesRecord(37, new DateTime(2020, 03, 27), 150.0, SaleStatus.Pending, s2);
                SalesRecord r38 = new SalesRecord(38, new DateTime(2020, 03, 29), 2300.0, SaleStatus.Pending, s3);
                SalesRecord r39 = new SalesRecord(39, new DateTime(2020, 04, 01), 19000.0, SaleStatus.Billed, s4);
                SalesRecord r40 = new SalesRecord(40, new DateTime(2020, 04, 01), 3600.0, SaleStatus.Pending, s5);
                SalesRecord r41 = new SalesRecord(41, new DateTime(2020, 04, 02), 10000.0, SaleStatus.Billed, s6);
                SalesRecord r42 = new SalesRecord(42, new DateTime(2020, 04, 03), 6900.0, SaleStatus.Canceled, s7);
                SalesRecord r43 = new SalesRecord(43, new DateTime(2020, 04, 03), 9800.0, SaleStatus.Billed, s1);
                SalesRecord r44 = new SalesRecord(44, new DateTime(2020, 04, 05), 3990.0, SaleStatus.Billed, s2);
                SalesRecord r45 = new SalesRecord(45, new DateTime(2020, 04, 05), 15000.0, SaleStatus.Canceled, s3);
                SalesRecord r46 = new SalesRecord(46, new DateTime(2020, 04, 05), 1500.0, SaleStatus.Pending, s4);
                SalesRecord r47 = new SalesRecord(47, new DateTime(2020, 04, 06), 1200.0, SaleStatus.Billed, s5);
                SalesRecord r48 = new SalesRecord(48, new DateTime(2020, 04, 06), 7000.0, SaleStatus.Pending, s6);
                SalesRecord r49 = new SalesRecord(49, new DateTime(2020, 04, 06), 16000.0, SaleStatus.Billed, s7);
                SalesRecord r50 = new SalesRecord(50, new DateTime(2020, 04, 06), 11500.0, SaleStatus.Canceled, s1);

                _context.Department.AddRange(d1, d2, d3, d4);

                _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7);

                _context.SalesRecord.AddRange(
                    r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                    r11, r12, r13, r14, r15, r15, r17, r18, r19, r20,
                    r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
                    r31, r32, r33, r34, r35, r36, r37, r38, r39, r40,
                    r41, r42, r43, r44, r45, r46, r47, r48, r49, r50
                    );

                _context.SaveChanges();
            }
        }
    }
}
