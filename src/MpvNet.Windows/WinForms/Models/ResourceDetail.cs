using Newtonsoft.Json;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpvNet.Windows.WinForms.Models
{
    public class ResourceDetail
    {
        [JsonProperty("vod_id")]
        [SugarColumn(IsPrimaryKey = true, ColumnName = "vod_id")]
        public long vodId { get; set; }// ": 44545,

        [JsonProperty("type_id")]
        [SugarColumn(ColumnName = "type_id")]
        public long typeId { get; set; }//": 60,
                                        //"type_id_1": 3,
                                        //"group_id": 0,
        [JsonProperty("vod_name")]
        [SugarColumn(ColumnName = "vod_name")]
        public string? vodName { get; set; }//": "武炼巅峰",
                                            //"vod_sub": "",
                                            //"vod_en": "wuliandianfeng",
                                            //"vod_status": 1,
                                            //"vod_letter": "W",
                                            //"vod_color": "",
                                            //"vod_tag": "",
                                            //"vod_class": "",
        [JsonProperty("vod_pic")]
        [SugarColumn(ColumnName = "vod_pic")]
        public string? vodPic { get; set; }//": "https://assets.heimuer.tv/imgs/2024/12/05/222a4de4871640f7a784cda04c994c63.jpg",
                                           //"vod_pic_thumb": "",
                                           //"vod_pic_slide": "",
                                           //"vod_pic_screenshot": "",
                                           //"vod_actor": "未知主演",
                                           //"vod_director": "未知导演",
                                           //"vod_writer": "",
                                           //"vod_behind": "",
                                           //"vod_blurb": "动画改编自莫默同名小说，由中影年年制作，企鹅影视阅文出品，腾讯视频独播，敬请期待！",
        [JsonProperty("vod_remarks")]
        [SugarColumn(ColumnName = "vod_remarks")]
        public string? vodRemarks { get; set; }//": "更新至【48】",
                                               //"vod_pubdate": "2024",
                                               //"vod_total": 0,
                                               //"vod_serial": "0",
                                               //"vod_tv": "",
                                               //"vod_weekday": "",
        [JsonProperty("vod_area")]
        [SugarColumn(ColumnName = "vod_area")]
        public string? vodArea { get; set; }//": "大陆",

        [JsonProperty("vod_lang")]
        [SugarColumn(ColumnName = "vod_lang")]
        public string? vodLang { get; set; }//": "国语",
                                            //"vod_year": "2024",
                                            //"vod_version": "",
                                            //"vod_state": "",
                                            //"vod_author": "",
                                            //"vod_jumpurl": "",
                                            //"vod_tpl": "",
                                            //"vod_tpl_play": "",
                                            //"vod_tpl_down": "",
                                            //"vod_isend": 0,
                                            //"vod_lock": 0,
                                            //"vod_level": 0,
                                            //"vod_copyright": 0,
                                            //"vod_points": 0,
                                            //"vod_points_play": 0,
                                            //"vod_points_down": 0,
                                            //"vod_hits": 44,
                                            //"vod_hits_day": 376,
                                            //"vod_hits_week": 751,
                                            //"vod_hits_month": 291,
                                            //"vod_duration": "",
                                            //"vod_up": 504,
                                            //"vod_down": 198,
                                            //"vod_score": "7.0",
                                            //"vod_score_all": 1938,
                                            //"vod_score_num": 646,
        [JsonProperty("vod_time")]
        [SugarColumn(ColumnName = "vod_time")]
        public DateTime? vodTime { get; set; }//": "2025-04-25 15:36:44",

        [JsonProperty("vod_time_add")]
        [SugarColumn(ColumnName = "vod_time_add")]
        public long? vodTimeAdd { get; set; }//": 1733369984,
                                             //"vod_time_hits": 0,
                                             //"vod_time_make": 0,
                                             //"vod_trysee": 0,
                                             //"vod_douban_id": 36055628,
                                             //"vod_douban_score": "0.0",
                                             //"vod_reurl": "",
                                             //"vod_rel_vod": "",
                                             //"vod_rel_art": "",
                                             //"vod_pwd": "",
                                             //"vod_pwd_url": "",
                                             //"vod_pwd_play": "",
                                             //"vod_pwd_play_url": "",
                                             //"vod_pwd_down": "",
                                             //"vod_pwd_down_url": "",
        [JsonProperty("vod_content")]
        [SugarColumn(ColumnName = "vod_content")]
        public string? vodContent { get; set; }//": "动画改编自莫默同名小说，由中影年年制作，企鹅影视阅文出品，腾讯视频独播，敬请期待！",
                                               //"vod_play_from": "heimuer",
                                               //"vod_play_server": "",
                                               //"vod_play_note": "",
        [JsonProperty("vod_play_url")]
        [SugarColumn(ColumnName = "vod_play_url")]
        public string? vodPlayUrl { get; set; }//": "1$https://m3u8.hmrvideo.com/play/4dddded4ae624962abe6eb795ecaba0e.m3u8#2$https://m3u8.hmrvideo.com/play/3ee93bdd2dd5432b8577659f95cf608f.m3u8#3$https://m3u8.hmrvideo.com/play/85cafafd6d484982862ff2d9930faa66.m3u8#4$https://m3u8.hmrvideo.com/play/a4231c156c874d62af2c42c88a24aadf.m3u8#5$https://m3u8.hmrvideo.com/play/8ae44c38e68e413a81dd334f7f7cf61e.m3u8#6$https://m3u8.hmrvideo.com/play/e5e8f49041744b4b9eaa91631af06ee4.m3u8#7$https://m3u8.hmrvideo.com/play/96d506ff32b2433b835ccb7a8db16514.m3u8#8$https://m3u8.hmrvideo.com/play/4e598dc5c7f843e3b120892da9a849b1.m3u8#9$https://m3u8.hmrvideo.com/play/716c2af2a5084433a9bca7744edc97b0.m3u8#10$https://m3u8.hmrvideo.com/play/353d69701f6241dbb087872d75d86a86.m3u8#11$https://m3u8.hmrvideo.com/play/60fd229341f2416898ed0e30b90c74a8.m3u8#12$https://m3u8.hmrvideo.com/play/a10b956b9c434e1fbec2ae12fcb4a2fe.m3u8#13$https://m3u8.hmrvideo.com/play/5873c8deb70e4e8587b26e187bd91d23.m3u8#14$https://m3u8.hmrvideo.com/play/29100ce65ee54effb9c16e6c8ecba73c.m3u8#15$https://m3u8.hmrvideo.com/play/baa1d91d5e014166879d4f99061f2d1a.m3u8#16$https://m3u8.hmrvideo.com/play/31ceabe2bfae4805b5b26bcee5d1af14.m3u8#17$https://m3u8.hmrvideo.com/play/cb92e9adfe95470bab30aca9cae04867.m3u8#18$https://m3u8.hmrvideo.com/play/075bf2e3948246b3a91d7f2998f66b51.m3u8#19$https://m3u8.hmrvideo.com/play/2c09de10b2b6493684db2c0ae3809b34.m3u8#20$https://m3u8.hmrvideo.com/play/e68c502ce2b84e009e76410aad7c9c78.m3u8#21$https://m3u8.hmrvideo.com/play/608c12e557ee4cc4899515b52f4f8c35.m3u8#22$https://m3u8.hmrvideo.com/play/5a2b63eeca414b97977dc019475ea2ed.m3u8#23$https://m3u8.hmrvideo.com/play/7269b88b432f4b7297c1c08231d90808.m3u8#24$https://m3u8.hmrvideo.com/play/f94018312bbd44d09025ac44ffea007c.m3u8#25$https://m3u8.hmrvideo.com/play/7ae56dd8b17945acbd8546813f744bc7.m3u8#26$https://m3u8.hmrvideo.com/play/6e2fae22c2a54b22b703af3bd6fdc937.m3u8#27$https://m3u8.hmrvideo.com/play/899e82bb502b400f8e7885b2eccf81fa.m3u8#28$https://m3u8.hmrvideo.com/play/e94c8f3a382b47d08241049a6ce8eafe.m3u8#29$https://m3u8.hmrvideo.com/play/a81d6d0376754a5fb03094d9c68ef8ab.m3u8#30$https://m3u8.hmrvideo.com/play/9527066e9e654e4384facf5fdb812591.m3u8#31$https://m3u8.hmrvideo.com/play/b69014769477401f9da48248bb585587.m3u8#32$https://m3u8.hmrvideo.com/play/2599b065912a4bb881b9c9f0d1f15bf8.m3u8#33$https://m3u8.hmrvideo.com/play/e2e0179357a24a35834d9fb19488d6b3.m3u8#34$https://m3u8.hmrvideo.com/play/41a30134525647abb37ffa1604e841b7.m3u8#35$https://m3u8.hmrvideo.com/play/b7264cfeea5a488ab812ae7c0caeb01d.m3u8#36$https://m3u8.hmrvideo.com/play/c99325d1a1a24522a17fda58f3cec7c1.m3u8#37$https://m3u8.hmrvideo.com/play/c014e9ee1e82491a915fde66da860c17.m3u8#38$https://m3u8.hmrvideo.com/play/a88322e9635b4f33964254219b012924.m3u8#39$https://m3u8.hmrvideo.com/play/65793d193bca4066ad01f8649fd90f29.m3u8#40$https://m3u8.hmrvideo.com/play/ef069d0699534972a9fea3b7f5c253c3.m3u8#41$https://m3u8.hmrvideo.com/play/2e58677fee8c465ca17470ca04f30b6e.m3u8#42$https://m3u8.hmrvideo.com/play/cfa1a183928d4330a91c5a7c6c52bf88.m3u8#43$https://m3u8.hmrvideo.com/play/96ceb1c9ef9344598363b6576211d02a.m3u8#44$https://m3u8.hmrvideo.com/play/d80c71bc9c3544d4a9db343d7da07b89.m3u8#45$https://m3u8.hmrvideo.com/play/1afcc3d69e9f4d9b941bf55283ef49dd.m3u8#46$https://m3u8.hmrvideo.com/play/b59940fa811f48f5a07af69d6b1ea577.m3u8#47$https://m3u8.hmrvideo.com/play/75620c5fabeb4459b31b64015b592f00.m3u8#48$https://m3u8.hmrvideo.com/play/41e1abb6c647481996d684d9bd02487b.m3u8",
                                               //"vod_down_from": "",
                                               //"vod_down_server": "",
                                               //"vod_down_note": "",
                                               //"vod_down_url": "",
                                               //"vod_plot": 0,
                                               //"vod_plot_name": "",
                                               //"vod_plot_detail": "",
        [JsonProperty("type_name")]
        [SugarColumn(ColumnName = "type_name")]
        public string? typeName { get; set; }//": "国产动漫"
    }
}
