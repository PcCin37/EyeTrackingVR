using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuseumTextController : MonoBehaviour
{
    public Text exhibitName;
    public Text exhibitNation;
    public Text exhibitDynasty;
    public Text exhibitTime;
    public Text exhibitCategory;
    public Text exhibitSize;
    public Text exhibitIntro;

    // Start is called before the first frame update
    void Start()
    {
        int exhibitNum = Random.Range(0, 1);

        if(exhibitNum == 0)
        {
            // exhibitName.text = "商戴金面罩青铜人头像";
            // exhibitNation.text = "国家: " + "中国";
            // exhibitDynasty.text = "年代: " + "商代";
            // exhibitTime.text = "年份: " + "公元前1600-1046年";
            // exhibitCategory.text = "分类: " + "青铜、雕像";
            // exhibitSize.text = "尺寸: " + "头纵径14.5," + "\n" + "横径12.6," + "\n" + "高42.5, 宽20.5cm";
            // exhibitIntro.text = "铜人头像为平顶，头发向后梳理，发辫垂于脑后，发辫上端用宽带套束，具有浓郁的地方民族发式风格。金面罩用金皮捶拓而成，大小、造型和铜头像面部特征相同，眼眉部镂空，制作颇为精致，给人以权威与神圣之感。";

            exhibitName.text = "Granite head of Amenemhat";
            exhibitNation.text = "Nation: " + "Africa Egypt";
            exhibitDynasty.text = "Period: " + "12th Dynasty";
            exhibitTime.text = "Year: " + "BC 1854-1808";
            exhibitCategory.text = "Category: " + "Statue";
            exhibitSize.text = "Size: " + "Height83, Width82," + "\n" + "Depth69cm";
            exhibitIntro.text = "Amenemhat III here wears the royal nemes headcloth, made of striped linen and bound tightly round his head. On his brow is the uraeus – the cobra symbol. This was used to represent many goddesses, perhaps most frequently Wadjet, protectress of Lower Egypt.";
        }

        // if(exhibitNum == 0)
        // {
        //     exhibitName.text = "Shang bronze human mask";
        //     exhibitNation.text = "Nation: " + "China";
        //     exhibitDynasty.text = "Period: " + "Shang";
        //     exhibitTime.text = "Year: " + "BC 1600-1046";
        //     exhibitCategory.text = "Category: " + "Bronze";
        //     exhibitSize.text = "Size: " + "Height40.8, Width27," + "\n" + "Thick0.4cm";
        //     exhibitIntro.text = "The bronze wares in the Sanxingdui Museum demonstrate the superb casting skills of the ancient Shu civilization. These bronze wares include sacrificial supplies, weapons, living utensils, etc., with unique shapes and smooth lines. Some bronze wares have exquisite decorations on the surface.";
        // }
        // else if(exhibitNum == 1)
        // {
        //     exhibitName.text = "Shang bronze figure wearing a gold mask";
        //     exhibitNation.text = "Nation: " + "China";
        //     exhibitDynasty.text = "Period: " + "Shang";
        //     exhibitTime.text = "Year: " + "BC 1600-1046";
        //     exhibitCategory.text = "Category: " + "Sculpture, Statue";
        //     exhibitSize.text = "Size: " + "Longitudinal Diameter14.5," + "\n" + "Transverse Diameter12.6," + "\n" + "Height42.5, Width20.5cm";
        //     exhibitIntro.text = "The head of the bronze figure is flat-topped, the hair is combed back, the braid hangs down behind the head, and the upper end of the braid is tied with a wide band, which has a strong local ethnic hair style. The gold mask is hammered out of gold skin. Its size and shape are the same as those of the bronze head.";
        // }

        // exhibitName.text = "玉雕水龟";
        // exhibitNation.text = "国家：" + "印度";
        // exhibitDynasty.text = "时期：" + "莫卧儿王朝";
        // exhibitTime.text = "年份：" + "1600年";
        // exhibitIntro.text = "这件栩栩如生的淡水龟像由整块软玉雕琢而成。在17世纪初，今天印度境内的大部分地区都处于莫卧儿帝国统治之下。1803年，位于印度北部的安拉阿巴德要塞正在进行施工。玉龟就在那时被发现于一座蓄水池的底部。1830年，玉龟来到了大英博物馆并成为馆藏的一部分。这座玉雕表现的是一只雌性棱背龟。其原产地亚穆纳河流经印度教圣城普瑞亚格并在那裡与恒河交汇。在位于1556到1605年的莫卧儿皇帝阿克巴在普瑞亚格修筑了防御工事，并把城名改为安拉阿巴德，意为“上帝之城”。";
    }
}
