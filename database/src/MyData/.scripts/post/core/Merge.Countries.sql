SET IDENTITY_INSERT [core].[Countries] ON;
BEGIN TRY
MERGE INTO [core].[Countries] AS [target]
USING (
    VALUES
    (1, N'Afghanistan', N'004', N'AF', N'AFG', N'Kabul', N'93', N'AFN', N'Afghan afghani', N'Ø‹', 3, 14),
    (2, N'Aland Islands', N'248', N'AX', N'ALA', N'Mariehamn', N'358', N'EUR', N'Euro', N'â‚¬', 4, 18),
    (3, N'Albania', N'008', N'AL', N'ALB', N'Tirana', N'355', N'ALL', N'Albanian lek', N'Lek', 4, 16),
    (4, N'Algeria', N'012', N'DZ', N'DZA', N'Algiers', N'213', N'DZD', N'Algerian dinar', N'Ø¯Ø¬', 1, 1),
    (5, N'American Samoa', N'016', N'AS', N'ASM', N'Pago Pago', N'1', N'USD', N'United States dollar', N'$', 5, 22),
    (6, N'Andorra', N'020', N'AD', N'AND', N'Andorra la Vella', N'376', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (7, N'Angola', N'024', N'AO', N'AGO', N'Luanda', N'244', N'AOA', N'Angolan kwanza', N'Kz', 1, 2),
    (8, N'Anguilla', N'660', N'AI', N'AIA', N'The Valley', N'1', N'XCD', N'Eastern Caribbean dollar', N'$', 2, 7),
    (9, N'Antarctica', N'010', N'AQ', N'ATA', N'', N'672', N'AAD', N'Antarctican dollar', N'$', 6, NULL),
    (10, N'Antigua and Barbuda', N'028', N'AG', N'ATG', N'St. John''s', N'1', N'XCD', N'Eastern Caribbean dollar', N'$', 2, 7),
    (11, N'Argentina', N'032', N'AR', N'ARG', N'Buenos Aires', N'54', N'ARS', N'Argentine peso', N'$', 2, 8),
    (12, N'Armenia', N'051', N'AM', N'ARM', N'Yerevan', N'374', N'AMD', N'Armenian dram', N'Ö', 3, 11),
    (13, N'Aruba', N'533', N'AW', N'ABW', N'Oranjestad', N'297', N'AWG', N'Aruban florin', N'Æ’', 2, 7),
    (14, N'Australia', N'036', N'AU', N'AUS', N'Canberra', N'61', N'AUD', N'Australian dollar', N'$', 5, 19),
    (15, N'Austria', N'040', N'AT', N'AUT', N'Vienna', N'43', N'EUR', N'Euro', N'â‚¬', 4, 17),
    (16, N'Azerbaijan', N'031', N'AZ', N'AZE', N'Baku', N'994', N'AZN', N'Azerbaijani manat', N'm', 3, 11),
    (18, N'Bahrain', N'048', N'BH', N'BHR', N'Manama', N'973', N'BHD', N'Bahraini dinar', N'.Ø¯.Ø¨', 3, 11),
    (19, N'Bangladesh', N'050', N'BD', N'BGD', N'Dhaka', N'880', N'BDT', N'Bangladeshi taka', N'à§³', 3, 14),
    (20, N'Barbados', N'052', N'BB', N'BRB', N'Bridgetown', N'1', N'BBD', N'Barbadian dollar', N'Bds$', 2, 7),
    (21, N'Belarus', N'112', N'BY', N'BLR', N'Minsk', N'375', N'BYN', N'Belarusian ruble', N'Br', 4, 15),
    (22, N'Belgium', N'056', N'BE', N'BEL', N'Brussels', N'32', N'EUR', N'Euro', N'â‚¬', 4, 17),
    (23, N'Belize', N'084', N'BZ', N'BLZ', N'Belmopan', N'501', N'BZD', N'Belize dollar', N'$', 2, 9),
    (24, N'Benin', N'204', N'BJ', N'BEN', N'Porto-Novo', N'229', N'XOF', N'West African CFA franc', N'CFA', 1, 3),
    (25, N'Bermuda', N'060', N'BM', N'BMU', N'Hamilton', N'1', N'BMD', N'Bermudian dollar', N'$', 2, 6),
    (26, N'Bhutan', N'064', N'BT', N'BTN', N'Thimphu', N'975', N'BTN', N'Bhutanese ngultrum', N'Nu.', 3, 14),
    (27, N'Bolivia', N'068', N'BO', N'BOL', N'Sucre', N'591', N'BOB', N'Bolivian boliviano', N'Bs.', 2, 8),
    (155, N'Bonaire, Sint Eustatius and Saba', N'535', N'BQ', N'BES', N'Kralendijk', N'599', N'USD', N'United States dollar', N'$', 2, 7),
    (28, N'Bosnia and Herzegovina', N'070', N'BA', N'BIH', N'Sarajevo', N'387', N'BAM', N'Bosnia and Herzegovina convertible mark', N'KM', 4, 16),
    (29, N'Botswana', N'072', N'BW', N'BWA', N'Gaborone', N'267', N'BWP', N'Botswana pula', N'P', 1, 5),
    (30, N'Bouvet Island', N'074', N'BV', N'BVT', N'', N'0055', N'NOK', N'Norwegian krone', N'ko', NULL, NULL),
    (31, N'Brazil', N'076', N'BR', N'BRA', N'Brasilia', N'55', N'BRL', N'Brazilian real', N'R$', 2, 8),
    (32, N'British Indian Ocean Territory', N'086', N'IO', N'IOT', N'Diego Garcia', N'246', N'USD', N'United States dollar', N'$', 1, 4),
    (33, N'Brunei', N'096', N'BN', N'BRN', N'Bandar Seri Begawan', N'673', N'BND', N'Brunei dollar', N'B$', 3, 13),
    (34, N'Bulgaria', N'100', N'BG', N'BGR', N'Sofia', N'359', N'BGN', N'Bulgarian lev', N'Ð›Ð².', 4, 15),
    (35, N'Burkina Faso', N'854', N'BF', N'BFA', N'Ouagadougou', N'226', N'XOF', N'West African CFA franc', N'CFA', 1, 3),
    (36, N'Burundi', N'108', N'BI', N'BDI', N'Bujumbura', N'257', N'BIF', N'Burundian franc', N'FBu', 1, 4),
    (37, N'Cambodia', N'116', N'KH', N'KHM', N'Phnom Penh', N'855', N'KHR', N'Cambodian riel', N'KHR', 3, 13),
    (38, N'Cameroon', N'120', N'CM', N'CMR', N'Yaounde', N'237', N'XAF', N'Central African CFA franc', N'FCFA', 1, 2),
    (39, N'Canada', N'124', N'CA', N'CAN', N'Ottawa', N'1', N'CAD', N'Canadian dollar', N'$', 2, 6),
    (40, N'Cape Verde', N'132', N'CV', N'CPV', N'Praia', N'238', N'CVE', N'Cape Verdean escudo', N'$', 1, 3),
    (41, N'Cayman Islands', N'136', N'KY', N'CYM', N'George Town', N'1', N'KYD', N'Cayman Islands dollar', N'$', 2, 7),
    (42, N'Central African Republic', N'140', N'CF', N'CAF', N'Bangui', N'236', N'XAF', N'Central African CFA franc', N'FCFA', 1, 2),
    (43, N'Chad', N'148', N'TD', N'TCD', N'N''Djamena', N'235', N'XAF', N'Central African CFA franc', N'FCFA', 1, 2),
    (44, N'Chile', N'152', N'CL', N'CHL', N'Santiago', N'56', N'CLP', N'Chilean peso', N'$', 2, 8),
    (45, N'China', N'156', N'CN', N'CHN', N'Beijing', N'86', N'CNY', N'Chinese yuan', N'Â¥', 3, 12),
    (46, N'Christmas Island', N'162', N'CX', N'CXR', N'Flying Fish Cove', N'61', N'AUD', N'Australian dollar', N'$', 5, 19),
    (47, N'Cocos (Keeling) Islands', N'166', N'CC', N'CCK', N'West Island', N'61', N'AUD', N'Australian dollar', N'$', 5, 19),
    (48, N'Colombia', N'170', N'CO', N'COL', N'BogotÃ¡', N'57', N'COP', N'Colombian peso', N'$', 2, 8),
    (49, N'Comoros', N'174', N'KM', N'COM', N'Moroni', N'269', N'KMF', N'Comorian franc', N'CF', 1, 4),
    (50, N'Congo', N'178', N'CG', N'COG', N'Brazzaville', N'242', N'XAF', N'Congolese Franc', N'CDF', 1, 2),
    (52, N'Cook Islands', N'184', N'CK', N'COK', N'Avarua', N'682', N'NZD', N'New Zealand dollar', N'$', 5, 22),
    (53, N'Costa Rica', N'188', N'CR', N'CRI', N'San Jose', N'506', N'CRC', N'Costa Rican colÃ³n', N'â‚¡', 2, 9),
    (54, N'Cote D''Ivoire (Ivory Coast)', N'384', N'CI', N'CIV', N'Yamoussoukro', N'225', N'XOF', N'West African CFA franc', N'CFA', 1, 3),
    (55, N'Croatia', N'191', N'HR', N'HRV', N'Zagreb', N'385', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (56, N'Cuba', N'192', N'CU', N'CUB', N'Havana', N'53', N'CUP', N'Cuban peso', N'$', 2, 7),
    (249, N'CuraÃ§ao', N'531', N'CW', N'CUW', N'Willemstad', N'599', N'ANG', N'Netherlands Antillean guilder', N'Æ’', 2, 7),
    (57, N'Cyprus', N'196', N'CY', N'CYP', N'Nicosia', N'357', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (58, N'Czech Republic', N'203', N'CZ', N'CZE', N'Prague', N'420', N'CZK', N'Czech koruna', N'KÄ', 4, 15),
    (51, N'Democratic Republic of the Congo', N'180', N'CD', N'COD', N'Kinshasa', N'243', N'CDF', N'Congolese Franc', N'FC', 1, 2),
    (59, N'Denmark', N'208', N'DK', N'DNK', N'Copenhagen', N'45', N'DKK', N'Danish krone', N'Kr.', 4, 18),
    (60, N'Djibouti', N'262', N'DJ', N'DJI', N'Djibouti', N'253', N'DJF', N'Djiboutian franc', N'Fdj', 1, 4),
    (61, N'Dominica', N'212', N'DM', N'DMA', N'Roseau', N'1', N'XCD', N'Eastern Caribbean dollar', N'$', 2, 7),
    (62, N'Dominican Republic', N'214', N'DO', N'DOM', N'Santo Domingo', N'1', N'DOP', N'Dominican peso', N'$', 2, 7),
    (64, N'Ecuador', N'218', N'EC', N'ECU', N'Quito', N'593', N'USD', N'United States dollar', N'$', 2, 8),
    (65, N'Egypt', N'818', N'EG', N'EGY', N'Cairo', N'20', N'EGP', N'Egyptian pound', N'Ø¬.Ù…', 1, 1),
    (66, N'El Salvador', N'222', N'SV', N'SLV', N'San Salvador', N'503', N'USD', N'United States dollar', N'$', 2, 9),
    (67, N'Equatorial Guinea', N'226', N'GQ', N'GNQ', N'Malabo', N'240', N'XAF', N'Central African CFA franc', N'FCFA', 1, 2),
    (68, N'Eritrea', N'232', N'ER', N'ERI', N'Asmara', N'291', N'ERN', N'Eritrean nakfa', N'Nfk', 1, 4),
    (69, N'Estonia', N'233', N'EE', N'EST', N'Tallinn', N'372', N'EUR', N'Euro', N'â‚¬', 4, 18),
    (212, N'Eswatini', N'748', N'SZ', N'SWZ', N'Mbabane', N'268', N'SZL', N'Lilangeni', N'E', 1, 5),
    (70, N'Ethiopia', N'231', N'ET', N'ETH', N'Addis Ababa', N'251', N'ETB', N'Ethiopian birr', N'Nkf', 1, 4),
    (71, N'Falkland Islands', N'238', N'FK', N'FLK', N'Stanley', N'500', N'FKP', N'Falkland Islands pound', N'Â£', 2, 8),
    (72, N'Faroe Islands', N'234', N'FO', N'FRO', N'Torshavn', N'298', N'DKK', N'Danish krone', N'Kr.', 4, 18),
    (73, N'Fiji Islands', N'242', N'FJ', N'FJI', N'Suva', N'679', N'FJD', N'Fijian dollar', N'FJ$', 5, 20),
    (74, N'Finland', N'246', N'FI', N'FIN', N'Helsinki', N'358', N'EUR', N'Euro', N'â‚¬', 4, 18),
    (75, N'France', N'250', N'FR', N'FRA', N'Paris', N'33', N'EUR', N'Euro', N'â‚¬', 4, 17),
    (76, N'French Guiana', N'254', N'GF', N'GUF', N'Cayenne', N'594', N'EUR', N'Euro', N'â‚¬', 2, 8),
    (77, N'French Polynesia', N'258', N'PF', N'PYF', N'Papeete', N'689', N'XPF', N'CFP franc', N'â‚£', 5, 22),
    (78, N'French Southern Territories', N'260', N'TF', N'ATF', N'Port-aux-Francais', N'262', N'EUR', N'Euro', N'â‚¬', 1, 5),
    (79, N'Gabon', N'266', N'GA', N'GAB', N'Libreville', N'241', N'XAF', N'Central African CFA franc', N'FCFA', 1, 2),
    (81, N'Georgia', N'268', N'GE', N'GEO', N'Tbilisi', N'995', N'GEL', N'Georgian lari', N'áƒš', 3, 11),
    (82, N'Germany', N'276', N'DE', N'DEU', N'Berlin', N'49', N'EUR', N'Euro', N'â‚¬', 4, 17),
    (83, N'Ghana', N'288', N'GH', N'GHA', N'Accra', N'233', N'GHS', N'Ghanaian cedi', N'GHâ‚µ', 1, 3),
    (84, N'Gibraltar', N'292', N'GI', N'GIB', N'Gibraltar', N'350', N'GIP', N'Gibraltar pound', N'Â£', 4, 16),
    (85, N'Greece', N'300', N'GR', N'GRC', N'Athens', N'30', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (86, N'Greenland', N'304', N'GL', N'GRL', N'Nuuk', N'299', N'DKK', N'Danish krone', N'Kr.', 2, 6),
    (87, N'Grenada', N'308', N'GD', N'GRD', N'St. George''s', N'1', N'XCD', N'Eastern Caribbean dollar', N'$', 2, 7),
    (88, N'Guadeloupe', N'312', N'GP', N'GLP', N'Basse-Terre', N'590', N'EUR', N'Euro', N'â‚¬', 2, 7),
    (89, N'Guam', N'316', N'GU', N'GUM', N'Hagatna', N'1', N'USD', N'United States dollar', N'$', 5, 21),
    (90, N'Guatemala', N'320', N'GT', N'GTM', N'Guatemala City', N'502', N'GTQ', N'Guatemalan quetzal', N'Q', 2, 9),
    (91, N'Guernsey and Alderney', N'831', N'GG', N'GGY', N'St Peter Port', N'44', N'GBP', N'British pound', N'Â£', 4, 18),
    (92, N'Guinea', N'324', N'GN', N'GIN', N'Conakry', N'224', N'GNF', N'Guinean franc', N'FG', 1, 3),
    (93, N'Guinea-Bissau', N'624', N'GW', N'GNB', N'Bissau', N'245', N'XOF', N'West African CFA franc', N'CFA', 1, 3),
    (94, N'Guyana', N'328', N'GY', N'GUY', N'Georgetown', N'592', N'GYD', N'Guyanese dollar', N'$', 2, 8),
    (95, N'Haiti', N'332', N'HT', N'HTI', N'Port-au-Prince', N'509', N'HTG', N'Haitian gourde', N'G', 2, 7),
    (96, N'Heard Island and McDonald Islands', N'334', N'HM', N'HMD', N'', N'672', N'AUD', N'Australian dollar', N'$', NULL, NULL),
    (97, N'Honduras', N'340', N'HN', N'HND', N'Tegucigalpa', N'504', N'HNL', N'Honduran lempira', N'L', 2, 9),
    (98, N'Hong Kong S.A.R.', N'344', N'HK', N'HKG', N'Hong Kong', N'852', N'HKD', N'Hong Kong dollar', N'$', 3, 12),
    (99, N'Hungary', N'348', N'HU', N'HUN', N'Budapest', N'36', N'HUF', N'Hungarian forint', N'Ft', 4, 15),
    (100, N'Iceland', N'352', N'IS', N'ISL', N'Reykjavik', N'354', N'ISK', N'Icelandic krÃ³na', N'ko', 4, 18),
    (101, N'India', N'356', N'IN', N'IND', N'New Delhi', N'91', N'INR', N'Indian rupee', N'â‚¹', 3, 14),
    (102, N'Indonesia', N'360', N'ID', N'IDN', N'Jakarta', N'62', N'IDR', N'Indonesian rupiah', N'Rp', 3, 13),
    (103, N'Iran', N'364', N'IR', N'IRN', N'Tehran', N'98', N'IRR', N'Iranian rial', N'ï·¼', 3, 14),
    (104, N'Iraq', N'368', N'IQ', N'IRQ', N'Baghdad', N'964', N'IQD', N'Iraqi dinar', N'Ø¯.Ø¹', 3, 11),
    (105, N'Ireland', N'372', N'IE', N'IRL', N'Dublin', N'353', N'EUR', N'Euro', N'â‚¬', 4, 18),
    (106, N'Israel', N'376', N'IL', N'ISR', N'Jerusalem', N'972', N'ILS', N'Israeli new shekel', N'â‚ª', 3, 11),
    (107, N'Italy', N'380', N'IT', N'ITA', N'Rome', N'39', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (108, N'Jamaica', N'388', N'JM', N'JAM', N'Kingston', N'1', N'JMD', N'Jamaican dollar', N'J$', 2, 7),
    (109, N'Japan', N'392', N'JP', N'JPN', N'Tokyo', N'81', N'JPY', N'Japanese yen', N'Â¥', 3, 12),
    (110, N'Jersey', N'832', N'JE', N'JEY', N'Saint Helier', N'44', N'GBP', N'British pound', N'Â£', 4, 18),
    (111, N'Jordan', N'400', N'JO', N'JOR', N'Amman', N'962', N'JOD', N'Jordanian dinar', N'Ø§.Ø¯', 3, 11),
    (112, N'Kazakhstan', N'398', N'KZ', N'KAZ', N'Astana', N'7', N'KZT', N'Kazakhstani tenge', N'Ð»Ð²', 3, 10),
    (113, N'Kenya', N'404', N'KE', N'KEN', N'Nairobi', N'254', N'KES', N'Kenyan shilling', N'KSh', 1, 4),
    (114, N'Kiribati', N'296', N'KI', N'KIR', N'Tarawa', N'686', N'AUD', N'Australian dollar', N'$', 5, 21),
    (248, N'Kosovo', N'926', N'XK', N'XKX', N'Pristina', N'383', N'EUR', N'Euro', N'â‚¬', 4, 15),
    (117, N'Kuwait', N'414', N'KW', N'KWT', N'Kuwait City', N'965', N'KWD', N'Kuwaiti dinar', N'Ùƒ.Ø¯', 3, 11),
    (118, N'Kyrgyzstan', N'417', N'KG', N'KGZ', N'Bishkek', N'996', N'KGS', N'Kyrgyzstani som', N'Ð»Ð²', 3, 10),
    (119, N'Laos', N'418', N'LA', N'LAO', N'Vientiane', N'856', N'LAK', N'Lao kip', N'â‚­', 3, 13),
    (120, N'Latvia', N'428', N'LV', N'LVA', N'Riga', N'371', N'EUR', N'Euro', N'â‚¬', 4, 18),
    (121, N'Lebanon', N'422', N'LB', N'LBN', N'Beirut', N'961', N'LBP', N'Lebanese pound', N'Â£', 3, 11),
    (122, N'Lesotho', N'426', N'LS', N'LSO', N'Maseru', N'266', N'LSL', N'Lesotho loti', N'L', 1, 5),
    (123, N'Liberia', N'430', N'LR', N'LBR', N'Monrovia', N'231', N'LRD', N'Liberian dollar', N'$', 1, 3),
    (124, N'Libya', N'434', N'LY', N'LBY', N'Tripolis', N'218', N'LYD', N'Libyan dinar', N'Ø¯.Ù„', 1, 1),
    (125, N'Liechtenstein', N'438', N'LI', N'LIE', N'Vaduz', N'423', N'CHF', N'Swiss franc', N'CHf', 4, 17),
    (126, N'Lithuania', N'440', N'LT', N'LTU', N'Vilnius', N'370', N'EUR', N'Euro', N'â‚¬', 4, 18),
    (127, N'Luxembourg', N'442', N'LU', N'LUX', N'Luxembourg', N'352', N'EUR', N'Euro', N'â‚¬', 4, 17),
    (128, N'Macau S.A.R.', N'446', N'MO', N'MAC', N'Macao', N'853', N'MOP', N'Macanese pataca', N'$', 3, 12),
    (130, N'Madagascar', N'450', N'MG', N'MDG', N'Antananarivo', N'261', N'MGA', N'Malagasy ariary', N'Ar', 1, 4),
    (131, N'Malawi', N'454', N'MW', N'MWI', N'Lilongwe', N'265', N'MWK', N'Malawian kwacha', N'MK', 1, 4),
    (132, N'Malaysia', N'458', N'MY', N'MYS', N'Kuala Lumpur', N'60', N'MYR', N'Malaysian ringgit', N'RM', 3, 13),
    (133, N'Maldives', N'462', N'MV', N'MDV', N'Male', N'960', N'MVR', N'Maldivian rufiyaa', N'Rf', 3, 14),
    (134, N'Mali', N'466', N'ML', N'MLI', N'Bamako', N'223', N'XOF', N'West African CFA franc', N'CFA', 1, 3),
    (135, N'Malta', N'470', N'MT', N'MLT', N'Valletta', N'356', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (136, N'Man (Isle of)', N'833', N'IM', N'IMN', N'Douglas, Isle of Man', N'44', N'GBP', N'British pound', N'Â£', 4, 18),
    (137, N'Marshall Islands', N'584', N'MH', N'MHL', N'Majuro', N'692', N'USD', N'United States dollar', N'$', 5, 21),
    (138, N'Martinique', N'474', N'MQ', N'MTQ', N'Fort-de-France', N'596', N'EUR', N'Euro', N'â‚¬', 2, 7),
    (139, N'Mauritania', N'478', N'MR', N'MRT', N'Nouakchott', N'222', N'MRO', N'Mauritanian ouguiya', N'MRU', 1, 3),
    (140, N'Mauritius', N'480', N'MU', N'MUS', N'Port Louis', N'230', N'MUR', N'Mauritian rupee', N'â‚¨', 1, 4),
    (141, N'Mayotte', N'175', N'YT', N'MYT', N'Mamoudzou', N'262', N'EUR', N'Euro', N'â‚¬', 1, 4),
    (142, N'Mexico', N'484', N'MX', N'MEX', N'Ciudad de MÃ©xico', N'52', N'MXN', N'Mexican peso', N'$', 2, 9),
    (143, N'Micronesia', N'583', N'FM', N'FSM', N'Palikir', N'691', N'USD', N'United States dollar', N'$', 5, 21),
    (144, N'Moldova', N'498', N'MD', N'MDA', N'Chisinau', N'373', N'MDL', N'Moldovan leu', N'L', 4, 15),
    (145, N'Monaco', N'492', N'MC', N'MCO', N'Monaco', N'377', N'EUR', N'Euro', N'â‚¬', 4, 17),
    (146, N'Mongolia', N'496', N'MN', N'MNG', N'Ulan Bator', N'976', N'MNT', N'Mongolian tÃ¶grÃ¶g', N'â‚®', 3, 12),
    (147, N'Montenegro', N'499', N'ME', N'MNE', N'Podgorica', N'382', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (148, N'Montserrat', N'500', N'MS', N'MSR', N'Plymouth', N'1', N'XCD', N'Eastern Caribbean dollar', N'$', 2, 7),
    (149, N'Morocco', N'504', N'MA', N'MAR', N'Rabat', N'212', N'MAD', N'Moroccan dirham', N'DH', 1, 1),
    (150, N'Mozambique', N'508', N'MZ', N'MOZ', N'Maputo', N'258', N'MZN', N'Mozambican metical', N'MT', 1, 4),
    (151, N'Myanmar', N'104', N'MM', N'MMR', N'Nay Pyi Taw', N'95', N'MMK', N'Burmese kyat', N'K', 3, 13),
    (152, N'Namibia', N'516', N'NA', N'NAM', N'Windhoek', N'264', N'NAD', N'Namibian dollar', N'$', 1, 5),
    (153, N'Nauru', N'520', N'NR', N'NRU', N'Yaren', N'674', N'AUD', N'Australian dollar', N'$', 5, 21),
    (154, N'Nepal', N'524', N'NP', N'NPL', N'Kathmandu', N'977', N'NPR', N'Nepalese rupee', N'â‚¨', 3, 14),
    (156, N'Netherlands', N'528', N'NL', N'NLD', N'Amsterdam', N'31', N'EUR', N'Euro', N'â‚¬', 4, 17),
    (157, N'New Caledonia', N'540', N'NC', N'NCL', N'Noumea', N'687', N'XPF', N'CFP franc', N'â‚£', 5, 20),
    (158, N'New Zealand', N'554', N'NZ', N'NZL', N'Wellington', N'64', N'NZD', N'New Zealand dollar', N'$', 5, 19),
    (159, N'Nicaragua', N'558', N'NI', N'NIC', N'Managua', N'505', N'NIO', N'Nicaraguan cÃ³rdoba', N'C$', 2, 9),
    (160, N'Niger', N'562', N'NE', N'NER', N'Niamey', N'227', N'XOF', N'West African CFA franc', N'CFA', 1, 3),
    (161, N'Nigeria', N'566', N'NG', N'NGA', N'Abuja', N'234', N'NGN', N'Nigerian naira', N'â‚¦', 1, 3),
    (162, N'Niue', N'570', N'NU', N'NIU', N'Alofi', N'683', N'NZD', N'New Zealand dollar', N'$', 5, 22),
    (163, N'Norfolk Island', N'574', N'NF', N'NFK', N'Kingston', N'672', N'AUD', N'Australian dollar', N'$', 5, 19),
    (115, N'North Korea', N'408', N'KP', N'PRK', N'Pyongyang', N'850', N'KPW', N'North Korean Won', N'â‚©', 3, 12),
    (129, N'North Macedonia', N'807', N'MK', N'MKD', N'Skopje', N'389', N'MKD', N'Denar', N'Ð´ÐµÐ½', 4, 16),
    (164, N'Northern Mariana Islands', N'580', N'MP', N'MNP', N'Saipan', N'1', N'USD', N'United States dollar', N'$', 5, 21),
    (165, N'Norway', N'578', N'NO', N'NOR', N'Oslo', N'47', N'NOK', N'Norwegian krone', N'ko', 4, 18),
    (166, N'Oman', N'512', N'OM', N'OMN', N'Muscat', N'968', N'OMR', N'Omani rial', N'.Ø¹.Ø±', 3, 11),
    (167, N'Pakistan', N'586', N'PK', N'PAK', N'Islamabad', N'92', N'PKR', N'Pakistani rupee', N'â‚¨', 3, 14),
    (168, N'Palau', N'585', N'PW', N'PLW', N'Melekeok', N'680', N'USD', N'United States dollar', N'$', 5, 21),
    (169, N'Palestinian Territory Occupied', N'275', N'PS', N'PSE', N'East Jerusalem', N'970', N'ILS', N'Israeli new shekel', N'â‚ª', 3, 11),
    (170, N'Panama', N'591', N'PA', N'PAN', N'Panama City', N'507', N'PAB', N'Panamanian balboa', N'B/.', 2, 9),
    (171, N'Papua New Guinea', N'598', N'PG', N'PNG', N'Port Moresby', N'675', N'PGK', N'Papua New Guinean kina', N'K', 5, 20),
    (172, N'Paraguay', N'600', N'PY', N'PRY', N'Asuncion', N'595', N'PYG', N'Paraguayan guarani', N'â‚²', 2, 8),
    (173, N'Peru', N'604', N'PE', N'PER', N'Lima', N'51', N'PEN', N'Peruvian sol', N'S/.', 2, 8),
    (174, N'Philippines', N'608', N'PH', N'PHL', N'Manila', N'63', N'PHP', N'Philippine peso', N'â‚±', 3, 13),
    (175, N'Pitcairn Island', N'612', N'PN', N'PCN', N'Adamstown', N'870', N'NZD', N'New Zealand dollar', N'$', 5, 22),
    (176, N'Poland', N'616', N'PL', N'POL', N'Warsaw', N'48', N'PLN', N'Polish zÅ‚oty', N'zÅ‚', 4, 15),
    (177, N'Portugal', N'620', N'PT', N'PRT', N'Lisbon', N'351', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (178, N'Puerto Rico', N'630', N'PR', N'PRI', N'San Juan', N'1', N'USD', N'United States dollar', N'$', 2, 7),
    (179, N'Qatar', N'634', N'QA', N'QAT', N'Doha', N'974', N'QAR', N'Qatari riyal', N'Ù‚.Ø±', 3, 11),
    (180, N'Reunion', N'638', N'RE', N'REU', N'Saint-Denis', N'262', N'EUR', N'Euro', N'â‚¬', 1, 4),
    (181, N'Romania', N'642', N'RO', N'ROU', N'Bucharest', N'40', N'RON', N'Romanian leu', N'lei', 4, 15),
    (182, N'Russia', N'643', N'RU', N'RUS', N'Moscow', N'7', N'RUB', N'Russian ruble', N'â‚½', 4, 15),
    (183, N'Rwanda', N'646', N'RW', N'RWA', N'Kigali', N'250', N'RWF', N'Rwandan franc', N'FRw', 1, 4),
    (184, N'Saint Helena', N'654', N'SH', N'SHN', N'Jamestown', N'290', N'SHP', N'Saint Helena pound', N'Â£', 1, 3),
    (185, N'Saint Kitts and Nevis', N'659', N'KN', N'KNA', N'Basseterre', N'1', N'XCD', N'Eastern Caribbean dollar', N'$', 2, 7),
    (186, N'Saint Lucia', N'662', N'LC', N'LCA', N'Castries', N'1', N'XCD', N'Eastern Caribbean dollar', N'$', 2, 7),
    (187, N'Saint Pierre and Miquelon', N'666', N'PM', N'SPM', N'Saint-Pierre', N'508', N'EUR', N'Euro', N'â‚¬', 2, 6),
    (188, N'Saint Vincent and the Grenadines', N'670', N'VC', N'VCT', N'Kingstown', N'1', N'XCD', N'Eastern Caribbean dollar', N'$', 2, 7),
    (189, N'Saint-Barthelemy', N'652', N'BL', N'BLM', N'Gustavia', N'590', N'EUR', N'Euro', N'â‚¬', 2, 7),
    (190, N'Saint-Martin (French part)', N'663', N'MF', N'MAF', N'Marigot', N'590', N'EUR', N'Euro', N'â‚¬', 2, 7),
    (191, N'Samoa', N'882', N'WS', N'WSM', N'Apia', N'685', N'WST', N'Samoan tÄlÄ', N'SAT', 5, 22),
    (192, N'San Marino', N'674', N'SM', N'SMR', N'San Marino', N'378', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (193, N'Sao Tome and Principe', N'678', N'ST', N'STP', N'Sao Tome', N'239', N'STD', N'Dobra', N'Db', 1, 2),
    (194, N'Saudi Arabia', N'682', N'SA', N'SAU', N'Riyadh', N'966', N'SAR', N'Saudi riyal', N'ï·¼', 3, 11),
    (195, N'Senegal', N'686', N'SN', N'SEN', N'Dakar', N'221', N'XOF', N'West African CFA franc', N'CFA', 1, 3),
    (196, N'Serbia', N'688', N'RS', N'SRB', N'Belgrade', N'381', N'RSD', N'Serbian dinar', N'din', 4, 16),
    (197, N'Seychelles', N'690', N'SC', N'SYC', N'Victoria', N'248', N'SCR', N'Seychellois rupee', N'SRe', 1, 4),
    (198, N'Sierra Leone', N'694', N'SL', N'SLE', N'Freetown', N'232', N'SLL', N'Sierra Leonean leone', N'Le', 1, 3),
    (199, N'Singapore', N'702', N'SG', N'SGP', N'Singapur', N'65', N'SGD', N'Singapore dollar', N'$', 3, 13),
    (250, N'Sint Maarten (Dutch part)', N'534', N'SX', N'SXM', N'Philipsburg', N'1721', N'ANG', N'Netherlands Antillean guilder', N'Æ’', 2, 7),
    (200, N'Slovakia', N'703', N'SK', N'SVK', N'Bratislava', N'421', N'EUR', N'Euro', N'â‚¬', 4, 15),
    (201, N'Slovenia', N'705', N'SI', N'SVN', N'Ljubljana', N'386', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (202, N'Solomon Islands', N'090', N'SB', N'SLB', N'Honiara', N'677', N'SBD', N'Solomon Islands dollar', N'Si$', 5, 20),
    (203, N'Somalia', N'706', N'SO', N'SOM', N'Mogadishu', N'252', N'SOS', N'Somali shilling', N'Sh.so.', 1, 4),
    (204, N'South Africa', N'710', N'ZA', N'ZAF', N'Pretoria', N'27', N'ZAR', N'South African rand', N'R', 1, 5),
    (205, N'South Georgia', N'239', N'GS', N'SGS', N'Grytviken', N'500', N'GBP', N'British pound', N'Â£', 2, 8),
    (116, N'South Korea', N'410', N'KR', N'KOR', N'Seoul', N'82', N'KRW', N'Won', N'â‚©', 3, 12),
    (206, N'South Sudan', N'728', N'SS', N'SSD', N'Juba', N'211', N'SSP', N'South Sudanese pound', N'Â£', 1, 2),
    (207, N'Spain', N'724', N'ES', N'ESP', N'Madrid', N'34', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (208, N'Sri Lanka', N'144', N'LK', N'LKA', N'Colombo', N'94', N'LKR', N'Sri Lankan rupee', N'Rs', 3, 14),
    (209, N'Sudan', N'729', N'SD', N'SDN', N'Khartoum', N'249', N'SDG', N'Sudanese pound', N'.Ø³.Ø¬', 1, 1),
    (210, N'Suriname', N'740', N'SR', N'SUR', N'Paramaribo', N'597', N'SRD', N'Surinamese dollar', N'$', 2, 8),
    (211, N'Svalbard and Jan Mayen Islands', N'744', N'SJ', N'SJM', N'Longyearbyen', N'47', N'NOK', N'Norwegian krone', N'ko', 4, 18),
    (213, N'Sweden', N'752', N'SE', N'SWE', N'Stockholm', N'46', N'SEK', N'Swedish krona', N'ko', 4, 18),
    (214, N'Switzerland', N'756', N'CH', N'CHE', N'Bern', N'41', N'CHF', N'Swiss franc', N'CHf', 4, 17),
    (215, N'Syria', N'760', N'SY', N'SYR', N'Damascus', N'963', N'SYP', N'Syrian pound', N'LS', 3, 11),
    (216, N'Taiwan', N'158', N'TW', N'TWN', N'Taipei', N'886', N'TWD', N'New Taiwan dollar', N'$', 3, 12),
    (217, N'Tajikistan', N'762', N'TJ', N'TJK', N'Dushanbe', N'992', N'TJS', N'Tajikistani somoni', N'SM', 3, 10),
    (218, N'Tanzania', N'834', N'TZ', N'TZA', N'Dodoma', N'255', N'TZS', N'Tanzanian shilling', N'TSh', 1, 4),
    (219, N'Thailand', N'764', N'TH', N'THA', N'Bangkok', N'66', N'THB', N'Thai baht', N'à¸¿', 3, 13),
    (17, N'The Bahamas', N'044', N'BS', N'BHS', N'Nassau', N'1', N'BSD', N'Bahamian dollar', N'B$', 2, 7),
    (80, N'The Gambia ', N'270', N'GM', N'GMB', N'Banjul', N'220', N'GMD', N'Gambian dalasi', N'D', 1, 3),
    (63, N'Timor-Leste', N'626', N'TL', N'TLS', N'Dili', N'670', N'USD', N'United States dollar', N'$', 3, 13),
    (220, N'Togo', N'768', N'TG', N'TGO', N'Lome', N'228', N'XOF', N'West African CFA franc', N'CFA', 1, 3),
    (221, N'Tokelau', N'772', N'TK', N'TKL', N'', N'690', N'NZD', N'New Zealand dollar', N'$', 5, 22),
    (222, N'Tonga', N'776', N'TO', N'TON', N'Nuku''alofa', N'676', N'TOP', N'Tongan paÊ»anga', N'$', 5, 22),
    (223, N'Trinidad and Tobago', N'780', N'TT', N'TTO', N'Port of Spain', N'1', N'TTD', N'Trinidad and Tobago dollar', N'$', 2, 7),
    (224, N'Tunisia', N'788', N'TN', N'TUN', N'Tunis', N'216', N'TND', N'Tunisian dinar', N'Øª.Ø¯', 1, 1),
    (225, N'Turkey', N'792', N'TR', N'TUR', N'Ankara', N'90', N'TRY', N'Turkish lira', N'â‚º', 3, 11),
    (226, N'Turkmenistan', N'795', N'TM', N'TKM', N'Ashgabat', N'993', N'TMT', N'Turkmenistan manat', N'T', 3, 10),
    (227, N'Turks and Caicos Islands', N'796', N'TC', N'TCA', N'Cockburn Town', N'1', N'USD', N'United States dollar', N'$', 2, 7),
    (228, N'Tuvalu', N'798', N'TV', N'TUV', N'Funafuti', N'688', N'AUD', N'Australian dollar', N'$', 5, 22),
    (229, N'Uganda', N'800', N'UG', N'UGA', N'Kampala', N'256', N'UGX', N'Ugandan shilling', N'USh', 1, 4),
    (230, N'Ukraine', N'804', N'UA', N'UKR', N'Kyiv', N'380', N'UAH', N'Ukrainian hryvnia', N'â‚´', 4, 15),
    (231, N'United Arab Emirates', N'784', N'AE', N'ARE', N'Abu Dhabi', N'971', N'AED', N'United Arab Emirates dirham', N'Ø¥.Ø¯', 3, 11),
    (232, N'United Kingdom', N'826', N'GB', N'GBR', N'London', N'44', N'GBP', N'British pound', N'Â£', 4, 18),
    (233, N'United States', N'840', N'US', N'USA', N'Washington', N'1', N'USD', N'United States dollar', N'$', 2, 6),
    (234, N'United States Minor Outlying Islands', N'581', N'UM', N'UMI', N'', N'1', N'USD', N'United States dollar', N'$', 2, 6),
    (235, N'Uruguay', N'858', N'UY', N'URY', N'Montevideo', N'598', N'UYU', N'Uruguayan peso', N'$', 2, 8),
    (236, N'Uzbekistan', N'860', N'UZ', N'UZB', N'Tashkent', N'998', N'UZS', N'Uzbekistani soÊ»m', N'Ð»Ð²', 3, 10),
    (237, N'Vanuatu', N'548', N'VU', N'VUT', N'Port Vila', N'678', N'VUV', N'Vanuatu vatu', N'VT', 5, 20),
    (238, N'Vatican City State (Holy See)', N'336', N'VA', N'VAT', N'Vatican City', N'379', N'EUR', N'Euro', N'â‚¬', 4, 16),
    (239, N'Venezuela', N'862', N'VE', N'VEN', N'Caracas', N'58', N'VES', N'BolÃ­var', N'Bs', 2, 8),
    (240, N'Vietnam', N'704', N'VN', N'VNM', N'Hanoi', N'84', N'VND', N'Vietnamese Ä‘á»“ng', N'â‚«', 3, 13),
    (241, N'Virgin Islands (British)', N'092', N'VG', N'VGB', N'Road Town', N'1', N'USD', N'United States dollar', N'$', 2, 7),
    (242, N'Virgin Islands (US)', N'850', N'VI', N'VIR', N'Charlotte Amalie', N'1', N'USD', N'United States dollar', N'$', 2, 7),
    (243, N'Wallis and Futuna Islands', N'876', N'WF', N'WLF', N'Mata Utu', N'681', N'XPF', N'CFP franc', N'â‚£', 5, 22),
    (244, N'Western Sahara', N'732', N'EH', N'ESH', N'El-Aaiun', N'212', N'MAD', N'Moroccan dirham', N'MAD', 1, 1),
    (245, N'Yemen', N'887', N'YE', N'YEM', N'Sanaa', N'967', N'YER', N'Yemeni rial', N'ï·¼', 3, 11),
    (246, N'Zambia', N'894', N'ZM', N'ZMB', N'Lusaka', N'260', N'ZMW', N'Zambian kwacha', N'ZK', 1, 5),
    (247, N'Zimbabwe', N'716', N'ZW', N'ZWE', N'Harare', N'263', N'ZWL', N'Zimbabwe Dollar', N'$', 1, 4)
    ) AS [source] (
        Id,
        Name,
        Code,
        ISO2,
        ISO3,
        Capital,
        PhoneCore,
        Currency,
        CurrencyName,
        CurrencySymbol,
        RegionId,
        SubregionId
        )
    ON [target].[Id] = [source].[Id]
WHEN MATCHED
    THEN
        UPDATE
        SET 
            Name = [source].Name,
            Code = [source].Code,
            ISO2 = [source].ISO2,
            ISO3 = [source].ISO3,
            Capital = [source].Capital,
            PhoneCore = [source].PhoneCore,
            Currency = [source].Currency,
            CurrencyName = [source].CurrencyName,
            CurrencySymbol = [source].CurrencySymbol,
            RegionId = [source].RegionId,
            SubregionId = [source].SubregionId
WHEN NOT MATCHED BY TARGET
    THEN
        INSERT (
            Id,
        Name,
        Code,
        ISO2,
        ISO3,
        Capital,
        PhoneCore,
        Currency,
        CurrencyName,
        CurrencySymbol,
        RegionId,
        SubregionId
        )
        VALUES (
            Id,
        Name,
        Code,
        ISO2,
        ISO3,
        Capital,
        PhoneCore,
        Currency,
        CurrencyName,
        CurrencySymbol,
        RegionId,
        SubregionId
        )
OUTPUT $action
INTO @Changes;

END TRY
BEGIN CATCH
    PRINT N'Countries was unable to be updated'
END CATCH
SET IDENTITY_INSERT [core].[Countries] OFF;