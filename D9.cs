﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace AdventOfCode
{
    public class D9
    {
        public string m_str;
        public D9()
        {
            int n = 0;
            string str = "6967128031985339734736617280757038645745239290236581123874156665793751514720983617223858831792394521856119568164901557909564178891524619506666506195863925923014993023578874449690848884327968251127532261526073368241228992411935648185959886726847737539273014339031792790792181163051839724753167987312745189256012985096956465302299649632218176609140515847891570764951297112116773162211261180304738674164465189313169822290998065973987773519329134522837998977277795401965985111235892379859166544548520224968389423571472361776489613276127278129549321775058665191172457931730268248458944488752324062679047636539342011633567959256508397931398545527467667612596775360548544327439557146594531983927888755819778387135182176722477666223468574324931412377114749849943118511597585591951878321693622159731206251299725451260217825277179316870624526444285286618504385405933927184735432887376231168495240401479989280307715599967406448265096126268528998737643457885176674752226724147813478356498503199103821247485446662256272865360373548839825962624369223867028736696949890976630347080246094825594915668966939453080358862211921947782211051993580374011612635238245279646362326795988816653504285902983109486299911603193692558597124869762814068338572672760817282262867939895853091139150485810794664664152377932903447184983249462459626784359482660343463863392276675318244807463171287538793947799752174695482275016731270101212678135282810693420504127611162936136351139405084188230155355984562674250243995703719874755704812491040753412376721971169926356966893994518224925476926439679385357906661657087905048177095586863833021627724251497669913419599778759172623963133261383699942627149616868708529164197985565476080108310282573186348864792556864423597555431385371702120469770132428221340732285837473305843576917341391708632896720909716141826775814464345517485477860141087674390101367891265905190561534382232212520453553287793312683799643802596212445702939866495827499483259293675823623298018272552199310831939873412687441636993773993176512861127867892217748973877726269301031248545379892739016649972847452323045898710605121996085143069564994553893463697514552897093805272211340251799689887564074936740684915389491217265882727243360398328603164806793927371322099417449806731417716468728272796247046465795293590507055393152306539229283883099723471592885407343692264935434644737916545841069391563799514239121781277934850107638766198702917494593283194422926161384185369774831749981781335567731371551342694637030508962334381296568247286737594586735893533323927177413743710495282681646505575621624632681221073813954612357668794413815404829918193423235862078515215942296468865807159595315283257556916683791104187691334684227514563574465898488849224608449631185199257684968674765958311777149721924703576648647277377628627393730408899908841528995845812639571732438227464122016861099586969199552921253772338837195785951927287445980357771512445583172663152994756762631352633773558149429541912453799141363479465153478465457836716364217784321903780269619526253991323733814813142107069652356639854745650964944801831327686228968194922886213415632914940378012536727781631616923767178669788577043742066303027902126998184698739681032315789418355967250825348968125368050672452503385297952582581234595808644525812232252787199556143988975816814535495945147134352228298132135765135301389405460988333202875771521421889119220771876318161665384646715772718866789522862447034581533777181307439572696697078215311454713452099875572537750285032379487124281198361654669517473497944696621567675902365918212868998289444315591668779513088551650902157527640794045618050678974622641216184828179208128495290221615541050605672463318314593117927769472969744123088479446531844606691645062189917412370421083806969647182622846407192305787882268657029604860317144826512558967754225426581825186809399253382685399364551779883983556972635321328105673559220611722813066953537596297882756578847172956425568891590799377973713205026422710708262224388966270745154703354364374733078364019451972996393152122332426974748668294308371457041668837544386958745756028706430829480256815221267663688861566413175217683683955493017593041901476506161745399388994988151771166323572497924859065282055813957919285332797583081364642163375245057781973223633859740608894617065395940532399617389346752291193648157995940611615737473672229613934401974198178164252953491753113443059527347584832159937895178402316781718331811379143884325749981387979249934127824448729522817543480861188839127782890819782231685325020823985683151287724865453924258321377268932893948466691991540192942448634696786677578897149165942257746679376485490687826927296632322541875711279651550276968871946744440677563997233229318319785658768601641389927838657413335663793582878748829762233148036123184646369939131425874514531929450642168274341921911813115549125344849587421616395216565358513633176218559311914409776771957366466862663976881858094487010473790886423716163543874215915216341593146237638614588916527979617483352135399111978677358208777425469429733605680184875708578222439977692378824326235271336965053124253276540661730831157725559285462571578996853439993983620576481967926809064192036788328826110121537875238897822319375574844522879618878406538148250851852923789294156474054962659674267296149165854281937201990285496416042574293349329217616538337115845922675897825433114911746577312569461753765877733411454477287138266521975166265318241332985541765965335534440546614791988976040805699189792392538375692665332545192332681252330105076431798625178748849193969269843125062925380153875797022507255297512638214567061322066159597222028507447448776549882382687873438943793146454963254768369121594686367924342346898236346567726589093885780335499414581537290799336621090576238475622157598214986975789941496102353387977904973275040441960305214324178962791896479924993641526485421908725687032183247712236331230918554481960418130205790931791554460295656919071843541616970477290577688817163748375487043206232225398682396641867145440157812427771545242767061861349424628353250602122396945557923523685841164953578441913712817733293658759265485156391181078105534293946755636135353369264604535124971254294184375532142537339627313715196841931958380952198842545763835153188546985932242235828378852903982277261929149416163187384558746393843351377413019562720271541925166276977758778473162823160664852881019486897459485749317668222764819186958382119195327543982119093987111455358765056556572765944267568214978173598648695122115798641901967739716233052977125117265267642965564763119831027866360166868427413286972978473394978186247967545412476406624928592944882774463426147562325613171916572219673698396151057595356144639183824568897824336787095753848831632226942363679633744309557941776612662331370911913754265158231967145498860569996804658336383402031825310356061823049656977429268282084616187496413228126893251962419457710283395179822535233624933493143405729878172262355658241361949124392192080103953435499748819844361584043118359197966549087961362245760458573588790663480924025343862934176743266443376759169681974623160146125905781303137882198312610954279302542659529505141428066621285481548715856912137416625234645992055166662619560679073906428171125773474342296819788291299852987322371932471911644775923282833889167613667146727476227393080146380537458873272195455344340642122575514892910261115333687888475668416282349404767855164751354271966616582519671529772767197301175861414649386782573868166984411651753903575168551539073213762794598879339811924903869867588626720634532719118962429125485251817988443923565378323362052169145428560866113964428295171546273853735659812569361713027775476478670863841192084853534298031222769914023894442438438385764328715473311544893651363625095352728755624793165164333914723719515794143668166168893544961346728527266534357969538729627169266456955912777457340742961386259184337791986431280641334948880358193577050278049999352657364576625505288897953625913367645274827293338194724916835581098312335139854985651712895492419708277515313549795279972995779641654758957565979395165376092836077933576393046678174697718252069676288397765207230152992977686189311668266638633623024964526648890264742576015654154977442914017365965379575897927622952906474678475551270202536997729995872601190274045529726321579611313358496125842655460452320569394164676378460586665911346195349995127969359655627476041999470251381694689613413658749927424497698978625367929962649585862274384256121505386922540345139721860665670177165374653173273699551103288183555991929369829535530734826127167972191582777566852341932704918581451108885715784807088992028359492661617853530425121341144216087272926507364325584102689118352791242201346438147176393123086147275526590185288788819862691767965401716574432245476596720589058493787918657341697155967606555621782859343685167981760879646803737868268424748693918656171654792447082695143675948306489532123428694198918628462477072251385597294597533487850551461202515455763804280146566899550821187763426655338883916176625923979935238829839703166203963378923381546256475343034416863255822705317369674973820931181544832743088378663644850221430522875605483988485751132828490819833719112992714837775765157211316306343795693659033121742439140995510814175447569368262471634456434385533895567575516761525334050502664242994785537955982512350658965356087228544522273337210618581869684953779397937509781424171247071573275221250163721846886985067384733572375734696726618762135773846577627477831292861127479586349629342954012745348201760975112683550147729891631915934562747291194932581681668621272198252474029599469814871507323378650762319248596843664886729355073346956491659156090791970769994439037732376218385134112801871935270979920539716606048535071615688198165394074306660143651797213186673368354714633224740904818363564607434487678861734149923534768151225876930321559479911421610897812577519591040292272376884526214866339787684436051141085834518289477823572475337295073471142219821985831977620935625233986709026773212471248517442194848361153508672597159936491144450225946563152689479222923453927886255287547164495968556145572462411543557357993129035307116942784829450939112274278507033825247237256277029599163335751232864834138267691547059572853953713884175777939458620642458233273618520388593562884631112947094401687294078345673287083792159234125836450662095959382155021408367308417332991934788192954321251827058914228805872417252209564761792962755197576109332158670666583961229115583257156735716999451291730688254804526754659731069836374718389424666649443821550792821499098285776782225194159778090336091426364915635556276848697649887812470873696413695607017253741165026639840393056747552166743311076216830252513519029889578384828938526566855757460415220296168171317925679607346747733839225678678741091266232344334451085926473785887226382503875958243132163926560126690265054365223323653827358379039747369953518873688415927864417844777597153988597523887137426654759822616252127955358528952667352506572821229911631195238281662252184601354497458996830785921227963434821796281559363554032566063318489707248795182187419629454809428865849925844346752902470568859731440847037444275765937717921743533208393823137436876543876526323418494984946626667391139655247542796124943661398341088795319323931956066464910452454308330911511161015401552506069985988269855655260593032176787871096746434561317346440368463472421797475692225309736729035974325515413437882789839366817413175808555395993716894683939293613427937773096782045983474383636492874534016328240316254291570912715562610359890606419484770637268322729286996554065595359524249814665852624886946694996207880781326738368244279521581901366838931556391582349342130262175211995828054679063623987687459492811211074874973765187387560586579973697999724491252179679894999418912142111645010741830751669238131664332103364995580925932724163397425748748453550424951988581303529203246588445876664285220741056333835777746218573107686326036352167352332195040463464836443923836323755272871936285111252598965546599425097411318817810707253776159309211166648917342639368425980373866854624727025886714883231489342935494809533569498505929466538258960149575976021128155887131921064956314368954293489909822473287929851711612974019549384423562602283151294412426173537706050623325168490384183657332213930283544157767737324881916253057225452753176767168169669734789987766474483908940654964187581619950301619803745806834214589636924707244459595437722925025162624343275836781563752338919413142461164422122701346259877878385263670714481752946432440644793416574432618433058232593717298643534303144988863699354208933374724403837138543645556322827123632547251878923692177707160223873939247202597774386542199214411126892612818764843121266752112924243331285629542432946812545667651589888992486383548482070628313749681328916145472989119141080947141402522569549187813186146827214233624437566477192687330241228231360851965338832924835319223225217227125682167362633318166764061143250781223472763897353345022402472206873734620834180368610527120771717602632681357292283731175742081893524434065735653522739171896892720249528734382843979132964411349693877893557478641847739467743325144473255624813212899495790143282643698121020579043431918511150747961562171365923154276423162373216473522518952356392354214818333909998892313798855152581384387747764315041333236334149906923875268562093684765806624489362299544673820862093894874376512206353506297684699524995936514723073661081619163621614354459552535793746788524792033919364796218533741546276539445337045549921775873431380925233809731173541403573359184985859192690288680755647693748275128693464172924323483904819454351626149528054509659102066432129907840672811522128171230151447446717267888922774263837809373904953858077996664132963809488557115573597924916766364815824723643575384306087588143825859369944206460562369898527157429387125875139345963746676877227601972492058108731448838682094607016986736416627284051407599397131273982146798379711744056505535437230874232612345565176334694936962148739382855531286694926931530265156477934936955555899469034463420648636965174549764795158804339142416429930683869663942157776184213312968517819726461235499406491886696477921634448261518442860836797215023408478323023544150551069321390948421836269536576365041772192473131731480297869655456219216324259438890842421613065569565499543189776581639643539514959587177978260993925228560115664281621361866712081811386186347587125525481741571468118427216676079383685684141973838111725246769164643102913822291493458412926869397671485572875817741908514868220587671735330366581422613213742561573921291821647439323974037572750156930186310827212683891836726548515924982852654422589637189293292398629354472143158914039726053335141965364792592896979548665574423734367988755354670679521877132751416226457636742669312653558234834558654594984821357671038313679983012745042519946572131927884842340754687839831122219546810348620198949424476643568306732135263726240496788673060584999984312498157366499723975842934677362443891336526219864334448527731258675148911769163176277182740177115451848684149378642287088201367876872386613712688964825125785471372317052679724271489137443836774818192335333943991293174341652653258502797421711392235391075996237529296164079338035852232467592391372185167424890972441935651484637856238304727125079788368586387444334451096665178641734866650937278686944472442922255496141799664651887317841269096388945876163245419121893935159275089155432809483778910356446466415533274943988636675112960762583482751123992136699192723231251105921656179597144822635808122504457606578229956636110471468452351407885325393936685706230747578578261106097735372851573455048798687513648351497499846475395247689801968236498103777109726376745424463279176997792879683661184653831599532842070903773961837918434977119663295663467184719593451307278767567696369877820753584733818577350906736399387984936618892659479745686635474842624865665534824446144774893648312133396294320254654166167439933238627868082933130657716279376799395724223413423452498149273321847712827574840842446918480218272332990616554761692756963302593131138393851381721475985991954435695142696989041795897607982759140933391294947476682517174332526336891776880404115538925731859314782916323698541378842339939803744421471188240839188121325149758453825185465289519367662106132733645955956173457632712404398225793187819706258412296542063684324331694605944771664647418915261267330377064679649325196171767614785592631296565514284351121333479681937788723475987275922225423818076634547262276674241588361388136623973217570863692464432832213988620792360672880881446193265919467264575183520841636496974354178221354756772136877131794441251401149563957382488877049911548369914756830276820166013674265586090152919802187795431253780461646611443425335195469149066665271926330549879424989156139445275242657729999761637357833323463942715889436933056785012544341469694785613203499296474941374566638226050932076271225871065959186724963354415669182841693217969574760315092277665791413701590345292727671333847478521305812199872999743359663439868985255948013627932859329436731692173793596961850205114328078337325123534805848883573406255358064458558255251175154233432592718485366434415732711696586506185678263593534453564324041968837425168416553123377771770238070114969103589499311771787997252234434161537909652815594218872558936859461847958481665401449412773464494469627148076172022126392275142232870622319791341984661924815246415518063219042659430347957309527134787195287184735804829801953925487319874288691111655294040515833862949976155657523466175271253135729359875728054225963514716628512956889827844521889408745941894324741133759817773792270512912738619509786288733217824878138624561391557193096147564718185609737162970983770475947539913108150916658484157455745103823812420101283416340975530246550909866652752349223978911718274784970683943243840665725957969313721412649179864853178179962996775756821116867108638968189269720635751831723277018325111191091228468411227898013665653691091393445725251887668197343135423766142942956128210841799834149492666706726985686252736623745745729648458639158781380872658966237447253216614829798683548134163345799154468335892427774925828782213688087807841825439551211903164924524106846223311129595257426479350416620389242265142557159556167739581982298227013729761295932331038692451763684276648152976911684593016434736645513912140258077973815965853564118578915459140607697136330236590274031745120292035195327406594755871776595476995872648104019282511168517758314429941358241142481419946565637372578226782325433212010956753439772747865904710692144589355989370258197122043323563813989658853123252729412492362555915985095812262652830723054451216841884866899992241797759223552197274693551333374803379567545605671871250329683716217951037373496975580402849469270346882561343745342397158593333866267719398126363128673776957653374377613202280591618897773116469662766523993871450931171322310417593998744897691339082585447927855926739796325487655432672477689708791609870932339826947735053195380221458517080684258563499856341747373937329668274422550325299574975325921868196146415493644312330529547728475366277648788926636955037922928395098479525188843503344654556197363664295928768499518189989623082937011352095189122505495357773484058211214517271688781668045228077887222197428212614201449473033312856545777996712881681262592406738452425739717282231763794549976793846602983973133999810891798447670113062854399964335714252391691248338324642862785844169837055647736157628298451169154251057498531288571379323929318362969606813275777877413813115192349481636557262745497419165596277284166844350909530604394658710896062935090409041611950119839131463239898281175913545687716109583399213539760196931161096837484207656501873441014585048376628357786654416374360418274955647663234805334394735939333774238239151913029429957992477175078835112757052413317787548157192714895539479254969556114791322962924695584524035481227161035495531836";
            //string str = "2333133121414131402";
            m_str = str;
        }
        public long star1()
        {
            long output = 0;
            string numbers = "";
            List<int> disk = new List<int>();
            int file_ID = 0;
            for (int i = 0; i < m_str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < (int)char.GetNumericValue(m_str[i]); j++)
                    {
                        disk.Add(file_ID);
                    }
                    file_ID++;
                }
                else
                {
                    for (int j = 0; j < (int)char.GetNumericValue(m_str[i]); j++)
                    {
                        disk.Add(-1);
                    }
                }
            }
            List<int> openpositions = new List<int>();
            for(int i = 0; i < disk.Count; i++)
            {
                if (disk[i] == -1)
                {
                    openpositions.Add(i);
                }
            }
            bool stop = false;
            for(int i = 0; i < disk.Count && openpositions.Count > 0 && stop == false; i++)
            {
                if (disk[disk.Count-1-i] != -1)
                {
                    if (openpositions[0] < disk.Count - 1 - i)
                    {
                        disk[openpositions[0]] = disk[disk.Count - 1 - i];
                        disk[disk.Count - 1 - i] = -1;
                        openpositions.RemoveAt(0);
                    }
                    else
                    {
                        stop = true;
                    }
                }
            }
            for(int i = 0; i < disk.Count; i++)
            {
                if (disk[i]!= -1)
                {
                    output += i * disk[i];
                }
            }
            return output;
        }
        public bool Space()
        {
            return true;
        }
        public long star2()
        {
            long output = 0;
            string numbers = "";
            List<(int,int,int)> files = new List<(int,int,int)>();
            List<int> disk = new List<int>();
            int file_ID = 0;
            for (int i = 0; i < m_str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    files.Add((file_ID, (int)char.GetNumericValue(m_str[i]), disk.Count));
                    for (int j = 0; j < (int)char.GetNumericValue(m_str[i]); j++)
                    {
                        disk.Add(file_ID);
                    }
                }
                else
                {
                    for (int j = 0; j < (int)char.GetNumericValue(m_str[i]); j++)
                    {
                        disk.Add(-1);
                    }
                    file_ID++;
                }
            }
            int count = 0;
            files.Reverse();
            foreach ((int, int, int) tuple in files)
            {
                int file = tuple.Item1;
                int size = tuple.Item2;
                int start = tuple.Item3;
                bool Copied = false;
                for (int i = 0; i < disk.Count && Copied == false && i < start; i++)
                {
                    if (disk[i] == -1)
                    {
                        count++;
                        if (count == size)
                        {
                            for (int k = 0; k < disk.Count; k++)
                            {
                                if (disk[k] == file)
                                {
                                    disk[k] = -1;
                                }
                            }
                            for (int j = 0; j < count; j++)
                            {
                                disk[i - j] = file;
                            }
                            Copied = true;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            for(int i = 0; i < disk.Count; i++)
            {
                if (disk[i]!= -1)
                {
                    output += i * disk[i];
                }
            }
            return output;
        }

        //ATTEMPT 1
        //if(i == disk.Count -2)
        //{
        //    int z = 0;
        //}
        //if (disk[disk.Count - 1 - i] != -1)
        //{
        //    bool Switched = false;
        //    for(int j = 0; j < disk.Count && Switched == false; j++)
        //    {
        //        if (disk[j] == -1)
        //        {
        //            int temp = disk[j];
        //            disk[j] = disk[disk.Count - 1 - i];
        //            disk[disk.Count - 1 - i] = temp;
        //            Switched = true;
        //        }
        //    }
        //}

        //ATTEMPT 2
        //bool Space = true;
        //int mem = 0;
        //for (int i = 0; i < disk.Count && Space == true; i++)
        //{
        //    if (disk[i] == -1)
        //    {
        //        bool Found = false;
        //        for(int j = 0; j < disk.Count && Found == false ; j++)
        //        {
        //            if (disk[disk.Count - j - 1] != -1)
        //            {
        //                disk[i] = disk[disk.Count - j - 1];
        //                disk[disk.Count - j - 1] = -1;
        //                mem = disk.Count - j - 1;
        //                Found = true;
        //            }
        //        }
        //    }
        //}
        //for (int i = 0; i < disk.Count; i++)
        //{
        //    if (disk[i] > 0)
        //    {
        //        output += disk[i] * i;
        //    }
        //}
    }
}
