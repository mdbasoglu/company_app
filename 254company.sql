/*
 Navicat Premium Data Transfer

 Source Server         : wampServer
 Source Server Type    : MySQL
 Source Server Version : 50724
 Source Host           : localhost:3306
 Source Schema         : 254company

 Target Server Type    : MySQL
 Target Server Version : 50724
 File Encoding         : 65001

 Date: 29/12/2019 20:52:41
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for ayarlar
-- ----------------------------
DROP TABLE IF EXISTS `ayarlar`;
CREATE TABLE `ayarlar`  (
  `pr_adi` varchar(17) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'Program adı 17 karakter max.',
  `pr_surumu` varchar(5) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'Program sürümü default v1.0',
  `pr_baslik` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'Türkiye\'nin yerli ve milli programı',
  `pr_webSite` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'Program yapımcısı web site',
  `pr_mailAdresi` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'Program yapımcısı mail adresi',
  `pr_simgesi` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'Program simgesi konumu'
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of ayarlar
-- ----------------------------
INSERT INTO `ayarlar` VALUES ('254 Company', 'v1.0', 'Türkiye\'nin yerli ve milli yazılımı', 'https://www.projevekod.com', 'projevekod@projevekod.com', NULL);

-- ----------------------------
-- Table structure for dil
-- ----------------------------
DROP TABLE IF EXISTS `dil`;
CREATE TABLE `dil`  (
  `dil_adi` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `dil_nesne_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `dil_nesne_degeri` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of dil
-- ----------------------------
INSERT INTO `dil` VALUES ('Türkçe', 'label_baslangic_aciklama1', 'Müşterilerinizi daha kolay yönetebilirsiniz.');
INSERT INTO `dil` VALUES ('Türkçe', 'label_baslangic_aciklama2', 'Personellerinizi daha hızlı takip edebilirsiniz.');
INSERT INTO `dil` VALUES ('Türkçe', 'label_baslangic_aciklama3', 'Kazancınızı güvenli ve hızlı kontrol edebilirsiniz.');
INSERT INTO `dil` VALUES ('Türkçe', 'label_baslangic_aciklama4', 'Tüm hazırlıklar tamamlandı.');
INSERT INTO `dil` VALUES ('Türkçe', 'label_baslangic_aciklama5', 'İşlerini kolaylaştırmak için sende aramıza katıl.');
INSERT INTO `dil` VALUES ('Türkçe', 'button_kaydol', 'Kaydol');
INSERT INTO `dil` VALUES ('Türkçe', 'button_girisYap', 'Giriş yap');
INSERT INTO `dil` VALUES ('Türkçe', 'label_baslangic_misafir_olarak_devam_et', 'Misafir olarak devam et');
INSERT INTO `dil` VALUES ('Türkçe', 'label_giris_aciklama1', 'İşletmenizi yönetmek artık çok kolay sadece bir kaç tıkla\r\npersonellerinizi, müşterilerinizi veya hesaplarınızı yönetebilirsiniz.\r\nPrograma hemen giriş yap ve sana özel fırsatları kaçırma.');
INSERT INTO `dil` VALUES ('Türkçe', 'button_geri', 'Geri');
INSERT INTO `dil` VALUES ('Türkçe', 'textBox_giris', 'Telefon, e-posta veya kullanıcı adı');
INSERT INTO `dil` VALUES ('Türkçe', 'textBox_sifre', 'Şifre');
INSERT INTO `dil` VALUES ('Türkçe', 'label_giris_sifreni_mi_unuttun', 'Şifreni mi unuttun?');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol', 'Hemen kaydol »');
INSERT INTO `dil` VALUES ('Türkçe', 'label_giris_burada_yeni_misin', 'Burada yeni misin?');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama1', 'Bilgileri eksiksiz doldurun ve işletmenizin\r\ntüm kontrollerini hızlı bir şekilde yönetin.');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama2', 'Hesabını oluştur');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama3', 'Ad*');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama4', 'Soyad*');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama5', 'Kullanıcı adı*');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama6', 'Telefon*');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama7', 'Şifre*');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama8', 'Şifre Tekrar*');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama9', 'E-Posta*');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kaydol_aciklama10', 'İşletme adı*');
INSERT INTO `dil` VALUES ('Türkçe', 'checkBox_kaydol_aciklama11', 'Kullanıcı sözleşmesini okudum anladım.');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_degisiklikler_kaybedilecektir', 'Değişiklikler kaybedilecektir onaylıyor musunuz?');
INSERT INTO `dil` VALUES ('Türkçe', 'button_kullaniciSozlesmesi', 'Kullanıcı Sözleşmesi');
INSERT INTO `dil` VALUES ('Türkçe', 'button_ileri', 'İleri');
INSERT INTO `dil` VALUES ('Türkçe', 'textBox_ePosta', 'E-posta adresi');
INSERT INTO `dil` VALUES ('Türkçe', 'label_sifremiUnuttum_aciklama2', 'Devam etmek icin e-posta adresini gir');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kayitOnay_aciklama1', 'Tebrikler başarıyla kaydoldunuz.\r\nYönetici onayından sonra programı kullanmaya devam edebilirsiniz.\r\nBu işlem biraz zaman alacaktır.');
INSERT INTO `dil` VALUES ('Türkçe', 'label_kayitOnay_aciklama2', 'Başvurunuz gönderilmiştir.\r\nBaşvuru durumunu görüntülemek için giriş yapabilirsiniz.');
INSERT INTO `dil` VALUES ('Türkçe', 'label_sifremiUnuttum_aciklama1', 'Sistemde kayıtlı mail adresi girdiğiniz takdirde,\r\nşifreniz mail adresinize gönderilecektir.');
INSERT INTO `dil` VALUES ('Türkçe', 'button_gonder', 'Gönder');
INSERT INTO `dil` VALUES ('Türkçe', 'label_sifremiUnuttum_aciklama3', 'Bu bilgiye erişimim yok');
INSERT INTO `dil` VALUES ('Türkçe', 'label_sifremiUnuttum_aciklama4', 'E-Posta erişimini kaybetmeniz halinde mevcut program yapımcısına mail atmanız gerekmektedir.\r\nProgram yapımcısı mail adresi : ');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_uyari_basligi', 'Dikkat önemli uyarı');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_hatali_mail', 'Mail adresini hatalı girdiniz.\r\nLütfen doğru bir mail adresi giriniz.');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_sunucu_kapali', 'Ana makinenin uzak bağlantısı kapalıdır.\r\nLütfen sistem yöneticinize başvurun.\r\nMisafir olarak devam edebilirsiniz.');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_bos_alan_mevcut', 'Lütfen boş alanları doldurunuz.');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_kullanici_sozlesmesi', 'Kullanıcı sözleşmesi onaylanmadı!\r\nProgramı kullanmadan önce lütfen Kullanıcı Sözleşmesi\'ni okuyunuz.\r\nGerekli koşulları kabul ettikten sonra programı kullanmaya devam edebilirsiniz');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_kullanici_adi_sifre_eksik', 'Kullanıcı adı ve şifre en az 6 karakter olmalıdır.');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_bilinmeyen_bir_hata_olustu', 'Bilinmeyen bir hata oluştu. Hata ayrıntıları için program yöneticinize başvurunuz.');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_sifreler_uyusmuyor', 'Şifreler uyuşmuyor.');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_onay_uyari', 'Hesabınız henüz bekleme aşamasındadır');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBpx_hatalı_kullanici_adi_veya_sifre', 'Kullanıcı adı veya şifreyi yanlış girdiniz. Lütfen tekrar deneyiniz.');
INSERT INTO `dil` VALUES ('Türkçe', 'messageBox_son_kullanma_tarihi', 'Program erişimi izniniz bitmiştir. Lütfen sistem yöneticinize başvurunuz.');
INSERT INTO `dil` VALUES ('Türkçe', 'button_profil', 'Profil');
INSERT INTO `dil` VALUES ('Türkçe', 'button_firmalar', 'Firmalar');
INSERT INTO `dil` VALUES ('Türkçe', 'button_duyuru', 'Duyuru');
INSERT INTO `dil` VALUES ('Türkçe', 'button_yoneticiler', 'Yöneticiler');
INSERT INTO `dil` VALUES ('Türkçe', 'button_destek', 'Destek');
INSERT INTO `dil` VALUES ('Türkçe', 'button_dil', 'Dil');
INSERT INTO `dil` VALUES ('Türkçe', 'button_ayarlar', 'Ayarlar');
INSERT INTO `dil` VALUES ('Türkçe', 'button_kadro', 'Personeller');
INSERT INTO `dil` VALUES ('Türkçe', 'button_istatistik', 'İstatistik');
INSERT INTO `dil` VALUES ('Türkçe', 'button_mesajlar', 'Mesajlar');
INSERT INTO `dil` VALUES ('Türkçe', 'button_odalar', 'Odalar');
INSERT INTO `dil` VALUES ('Türkçe', 'button_musteriler', 'Müşteriler');

-- ----------------------------
-- Table structure for dil_ayar
-- ----------------------------
DROP TABLE IF EXISTS `dil_ayar`;
CREATE TABLE `dil_ayar`  (
  `dil_adi` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `dil_kodu` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `aktif` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '1'
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of dil_ayar
-- ----------------------------
INSERT INTO `dil_ayar` VALUES ('Türkçe', 'tr_TR', '1');

-- ----------------------------
-- Table structure for duyuru
-- ----------------------------
DROP TABLE IF EXISTS `duyuru`;
CREATE TABLE `duyuru`  (
  `duyuru_bilgi` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of duyuru
-- ----------------------------
INSERT INTO `duyuru` VALUES ('');

-- ----------------------------
-- Table structure for firma_sahibi
-- ----------------------------
DROP TABLE IF EXISTS `firma_sahibi`;
CREATE TABLE `firma_sahibi`  (
  `firma_sahibi_ad` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'Firma sahibi adı',
  `firma_sahibi_soyad` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'Firma sahibi soyadı',
  `firma_sahibi_kullanici_adi` varchar(17) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'Firma sahibi kullanıcı adı',
  `firma_sahibi_telefon_numarasi` varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'Firma sahibi telefon numarası',
  `firma_sahibi_sifre` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'Firma sahibi şifresi',
  `firma_sahibi_eposta` varchar(80) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'Firma sahibi eposta',
  `firma_sahibi_isletme_adi` varchar(125) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'Firma sahbi işletme adı',
  `firma_sahibi_veritabani` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'Firma sahibi için oluşturulan veri tabanı adı',
  `firma_sahibi_kayit_tarihi` date NULL DEFAULT NULL COMMENT 'Firma sahibi kayıt arihi',
  `firma_sahibi_onay_durumu` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT 'Firma sahibi onay durumu varsayılan 0',
  `firma_sahibi_program_son_kullanma_tarihi` date NULL DEFAULT NULL COMMENT 'Firma sahibinin programın son kullanma tarihi',
  `firma_sahibi_profil_resimi` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT 'Firma sahibi rpofil fotoğrafı',
  PRIMARY KEY (`firma_sahibi_kullanici_adi`, `firma_sahibi_telefon_numarasi`, `firma_sahibi_eposta`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of firma_sahibi
-- ----------------------------
INSERT INTO `firma_sahibi` VALUES ('Ali', 'Köklü', 'projevekod', '+905372921615', '1', 'alikoklu254@outlook.com', 'Proje ve Kod Paylasim Platformu', NULL, '2019-12-08', '1', '2020-12-08', NULL);

-- ----------------------------
-- Table structure for program_yoneticileri
-- ----------------------------
DROP TABLE IF EXISTS `program_yoneticileri`;
CREATE TABLE `program_yoneticileri`  (
  `yonetici_kullanici_adi` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `yonetici_sifre` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `yonetici_profil_resimi` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`yonetici_kullanici_adi`) USING BTREE
) ENGINE = MyISAM CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of program_yoneticileri
-- ----------------------------
INSERT INTO `program_yoneticileri` VALUES ('alikoklu254', '1', NULL);

SET FOREIGN_KEY_CHECKS = 1;
