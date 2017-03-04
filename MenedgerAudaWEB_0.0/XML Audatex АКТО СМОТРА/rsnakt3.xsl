<?xml version="1.0" encoding="utf-8"?>
<!-- DWXMLSource="../../test.xml" -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" exclude-result-prefixes="a" xmlns:a="http://www.audatex.com/SAXIF" xmlns:xsi="http://www.w3.org/2001/XMLSchema">
	<xsl:output method="html" encoding="UTF-8"/>
	<xsl:template match="/">
		<!--AudaShare:Report:Rosno-->
		<!--MODULE:SHRPRINT-->
		<!--VERSION:1.2-->

		<html>
			<head>
				<script type="text/javascript">
					<xsl:text disable-output-escaping="yes">
<![CDATA[

var theyear=new Date();
var system_year=theyear.getFullYear();
var system_day=theyear.getDate();
var system_month=theyear.getMonth();
var system_hours=theyear.getHours();
var system_minutes=theyear.getMinutes();

window.onload=function(){
	document.getElementById('system_date').value=system_day+'.'+system_month+'.'+system_year;
	document.getElementById('start_time_hour').value=system_hours;
	document.getElementById('start_time_min').value=system_minutes;
}

function comboBoxChange(etv, td_id){
		document.getElementById(td_id).innerHTML=etv.options[etv.selectedIndex].value;	
}	

function inputTxtChange(etv, td_id){
		document.getElementById(td_id).innerHTML=etv.value;	
}
	
function checkEmptyValues(){
	var elem=document.getElementsByName('not_empty');
	for(i=0; i < elem.length; i++){
		if(elem[i].value==''){
			alert(elem[i].msg);
		}		
	}
}	
window.onbeforeprint = function(){
	checkEmptyValues()
}
]]>
</xsl:text>
				</script>

				<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
				<title>POCHO</title>


				<style type="text/css">
					<xsl:comment>@import url("css.css");</xsl:comment>
				</style>
				<style type="text/css" media="print">
					<xsl:comment>@import url("print.css");</xsl:comment>
				</style>
			</head>

			<body>
				<table width="790" border="0" cellspacing="0" cellpadding="0">
					<tr>
						<td align="left">
							<img src="ANYIMAGE.gif" width="113" height="32"/>
						</td>
						<td align="right" class="explanation">
							<br/>
							<br/>
						</td>
					</tr>
					<tr>
						<td colspan="2" align="center" class="bottom_borders">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2" align="center" class="bold_text_first_page">АКТ N
							<xsl:element name="input">
								<xsl:attribute name="class">input_text</xsl:attribute>
								<xsl:attribute name="type">text</xsl:attribute>
								<xsl:attribute name="value">
									<xsl:value-of select="a:Task/a:DisplayName"/>
								</xsl:attribute>
							</xsl:element>
						</td>
					</tr>
					<tr>
						<td colspan="2" align="center">
							<p align="center" class="bold_text_first_page">ОСМОТРА ТРАНСПОРТНОГО СРЕДСТВА</p>
						</td>
					</tr>
					<tr>
						<td colspan="2" align="center">
						</td>
					</tr>
					<tr>
						<td colspan="2" align="center">&#xA0;</td>
					</tr>
					<tr>
						<td width="181">Дата:
							<input name="system_date" type="text" class="input_text" id="system_date" style="width:60px"/>г.</td>
						<td width="563" align="center">Время осмотра:</td>
					</tr>
					<tr>
						<td width="181">&#xA0;</td>
						<td align="right">начало :
							<input name="system_date2" type="text" class="input_text" id="start_time_hour" style="width:20px" maxlength="2"/>час
							<input name="system_date4" type="text" class="input_text" id="start_time_min" style="width:20px" maxlength="2"/>мин</td>
					</tr>
					<tr>
						<td width="181">&#xA0;</td>
						<td align="right">окончание 
      :
							<input name="system_date3" type="text" class="input_text" id="finish_time_hour" style="width:20px" maxlength="2"/>час
							<input name="system_date5" type="text" class="input_text" id="finish_time_min" style="width:20px" maxlength="2"/>мин</td>
					</tr>
					<tr>
						<td width="181">&#xA0;</td>
						<td align="right">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2">Мною, специалистом

							<xsl:element name="input">
								<xsl:attribute name="class">input_text</xsl:attribute>
								<xsl:attribute name="type">text</xsl:attribute>
								<xsl:attribute name="style">width:400px</xsl:attribute>
								<xsl:attribute name="value">
									<xsl:value-of select="a:Task/a:AudaShareFullUserName"/>
								</xsl:attribute>
							</xsl:element>
						</td>
					</tr>
					<tr>
						<td colspan="2">на основании заявления страхователя  №
							<input name="not_empty" msg="Не введено значение “№” !" type="text" class="input_text" id="not_empty1"/>от «
							<label>
								<input name="not_empty" msg="Не введено значение “от” !" type="text" class="input_text" id="not_empty2"/>
							</label>»  по риску Ущерб произведен осмотр автомобиля</td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2">Код в системе Аудатэкс <xsl:value-of select="//a:ManufacturerCodeAX"/>&#xA0;<xsl:value-of select="//a:ModelCodeAX"/>&#xA0;<xsl:value-of select="//a:SubModelCodeAX"/></td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2" align="center">
							<table width="100%" border="0" cellspacing="0" cellpadding="0">
								<tr>
									<td width="91">Марка</td>
									<td width="250">
										<xsl:value-of select="a:Task/a:BasicClaimData/a:Vehicle/a:VehicleIdentification/a:ManufacturerName"/>, <xsl:value-of select="a:Task/a:BasicClaimData/a:Vehicle/a:VehicleIdentification/a:ModelName"/> , <xsl:value-of select="a:Task/a:BasicClaimData/a:Vehicle/a:VehicleIdentification/a:SubModelName"/></td>
									<td width="94">Гос.рег.№</td>
									<td>
										<xsl:value-of select="//a:PlateNumber"/>
									</td>
								</tr>
								<tr>
									<td>Двигатель</td>
									<td>
										<input name="textfield9" type="text" class="input_text" id="textfield9"/>
									</td>
									<td>Год выпуска</td>
									<td>
										<xsl:value-of select="normalize-space(substring(//a:RegistrationDate,1,4))"/>
									</td>
								</tr>
								<tr>
									<td>Кузов(VIN)</td>
									<td>
										<xsl:value-of select="a:Task/a:BasicClaimData/a:Vehicle/a:VehicleIdentification/a:VIN"/>
									</td>
									<td>Пробег</td>
									<td>
										<xsl:value-of select="a:Task/a:BasicClaimData/a:Vehicle/a:VehicleEngineering/a:Mileage"/>
										<xsl:value-of select="a:Task/a:BasicClaimData/a:Vehicle/a:VehicleEngineering/a:MileageUnit"/>
									</td>
								</tr>
								<tr>
									<td>Шасси</td>
									<td>
										<label>
											<input name="textfield4" type="text" class="input_text" id="textfield4"/>
										</label>
									</td>
									<td>Цвет</td>
									<td>
										<label>
											<input name="textfield5" type="text" class="input_text" id="textfield5"/>
										</label>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2">Дополнительные технические  данные (заполняются при необходимости):</td>
					</tr>
					<tr>
						<td colspan="2" class="bottom_borders">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2" class="bottom_borders">

							<table width="100%" border="0" cellpadding="0" cellspacing="1" class="w_table_bg">
								<xsl:for-each select="//a:ModelOptionDetail">
									<xsl:choose>
										<xsl:when test="position() mod 4 = 1">
											<tr/>
										</xsl:when>
										<xsl:otherwise></xsl:otherwise>
									</xsl:choose>
									<xsl:choose>
										<xsl:when test="a:MO">
											<td style="width:25%">
												<xsl:if test="not(a:MOIsPaintOption) or (a:MOIsPaintOption != 'true')">
													<xsl:value-of select="a:MODesc"/>
												</xsl:if>
											</td>
										</xsl:when>
										<xsl:otherwise></xsl:otherwise>
									</xsl:choose>
								</xsl:for-each>
							</table>
						</td>
					</tr>
					<tr>
						<td>&#xA0;</td>
						<td></td>
					</tr>
					<tr>
						<td>Собственник</td>
						<td>
							<xsl:value-of select="//a:LastName"/>&#xA0;<xsl:value-of select="//a:FirstName"/>&#xA0;<xsl:value-of select="//a:CompanyName"/></td>
					</tr>
					<tr>
						<td></td>
						<td>&#xA0;</td>
					</tr>
					<tr>
						<td>Адрес:</td>
						<td>
							<xsl:value-of select="//a:City"/>&#xA0;
							<xsl:choose>
								<xsl:when test="a:Task/a:BasicClaimData/a:Vehicle/a:VehicleAdmin/a:VehicleOwner/a:AddressList[1]/a:Address/a:Line1">
									<xsl:value-of select="a:Task/a:BasicClaimData/a:Vehicle/a:VehicleAdmin/a:VehicleOwner/a:AddressList[1]/a:Address/a:Line1"/>
								</xsl:when>
								<xsl:otherwise>
									<xsl:value-of select="a:Task/a:BasicClaimData/a:Vehicle/a:VehicleAdmin/a:VehicleOwner/a:AddressList[1]/a:Address/a:Line2"/>
								</xsl:otherwise>
							</xsl:choose>
						</td>
					</tr>
					<tr>
						<td></td>
						<td>&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2">
							<table width="100%" border="0" cellspacing="0" cellpadding="0">
								<tr>
									<td width="160" nowrap="nowrap">Условия страхования</td>
									<td width="160">
										<div id="condit" class="invisible_div"></div>
										<select name="select3" class="input_select" id="select" onchange="comboBoxChange(this,'condit')">
											<option value="" selected="selected"></option>
											<option value="Ущерб">Ущерб</option>
											<option value="Пожар">Пожар</option>
											<option value="Угон">Угон</option>
											<option value="Помощь на дороге">Помощь на дороге</option>
										</select>
									</td>
									<td width="180">Ответственность</td>
									<td>
										<label>
											<input name="textfield7" type="text" class="input_text" id="textfield7"/>
										</label>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2">
							<table width="100%" border="0" cellspacing="0" cellpadding="0">
								<tr>
									<td width="160">Место осмотра</td>
									<td>
										<div id="place" class="invisible_div"></div>
										<select name="select3" class="input_select" id="select" onchange="comboBoxChange(this,'place')">
											<option value="" selected="selected"></option>
											<option value="Смотровая площадка">Смотровая площадка</option>
											<option value="Улица">Улица</option>
											<option value="Гараж">Гараж</option>
										</select>
									</td>
								</tr>
								<tr>
									<td></td>
									<td align="center">
										<span class="explanation"></span>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td height="10" colspan="2">&#xA0;</td>
					</tr>

					<tr>
						<td colspan="2">
							<table width="100%" border="0" cellspacing="0" cellpadding="0">
								<tr>
									<td width="160" nowrap="nowrap">Погодные условия</td>
									<td width="160">
										<div id="weather" class="invisible_div"></div>
										<select name="select3" class="input_select" id="select" onchange="comboBoxChange(this,'weather')">
											<option value="" selected="selected"></option>
											<option value="Без осадков">Без осадков</option>
											<option value="Дождь">Дождь</option>
											<option value="Снег">Снег</option>
										</select>
									</td>
									<td width="180">Освещение</td>
									<td>
										<div id="offset" class="invisible_div"></div>
										<select name="select2" class="input_select" id="select2" onchange="comboBoxChange(this,'offset')">
											<option value="" selected="selected"></option>
											<option value="Светло">Светло</option>
											<option value="Сумерки">Сумерки</option>
											<option value="Темно">Темно</option>
										</select>
									</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2">Перед  началом осмотра номера агрегатов и цвет окраски соответствуют записям в техническом паспорте.</td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2" align="center" class="bold_text_first_page">ОСМОТРОМ ОБНАРУЖЕНЫ ПОВРЕЖДЕНИЯ:</td>
					</tr>
					<tr>
						<td colspan="2" align="center" class="bottom_borders">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2">

							<table width="100%" border="0" cellpadding="-1" cellspacing="0">
								<thead>
									<tr class="tnaglowek">
										<td width="103" align="center" class="w_header">Управляющий номер</td>
										<td width="119" align="center" class="w_header">Наименование  детали</td>
										<td width="74" align="center" class="w_header">Вид  ремонта</td>
										<td width="191" align="center" class="w_header">Рабочие  позиции (РП)</td>
										<td width="200" align="center" class="w_header">Вид  окраски</td>
										<td width="103" align="center" class="w_header" style="border-right:#000000 solid 1px">Примечание</td>
									</tr>
								</thead>
								<tbody>
									<xsl:for-each select="a:Task/a:CalculationList/a:CLASSCalculation/a:CLASSResult/a:CLASSXml/a:CalcData/a:SpareParts/a:PartDtls/a:PartDtl">
										<xsl:variable name="ThisGId" select="a:GId"/>
										<tr class=" " height="20">
											<td width="103" align="center" nowrap="nowrap" class="w_table">
												<xsl:value-of select="a:GId"/>
											</td>
											<td class="w_table">&#xA0;
												<xsl:choose>
													<xsl:when test="a:PartDesc">
														<xsl:value-of select="a:PartDesc"/>
													</xsl:when>
													<xsl:otherwise>
														<xsl:value-of select="a:RepDesc"/>
													</xsl:otherwise>
												</xsl:choose>
											</td>
											<td align="center" class="w_table">
												<xsl:value-of select="a:RepTyp"/>
											</td>
											<td align="center" class="w_table">

												<xsl:for-each select="//a:Labor/a:NetLabors/a:NetLabor">
													<xsl:if test="a:GId = $ThisGId">
														<xsl:if test="a:WuNet[@DspChar = '*'] or a:WuNo[@DspChar = '*']">
															<xsl:choose>
																<xsl:when test="a:WuNo">
																	<xsl:value-of select="format-number(substring-after(a:WuNo/@Val,'+'), '###0.0 ')"/>
																</xsl:when>
																<xsl:when test="a:WuNet">
																	<xsl:value-of select="format-number(substring-after(a:WuNet/@Val,'+'), '###0.0 ')"/>
																</xsl:when>
															</xsl:choose>
														</xsl:if>
													</xsl:if>
												</xsl:for-each>&#xA0;</td>
											<td width="200" align="center" class="w_table">
												<xsl:for-each select="//a:Paint">
													<xsl:for-each select="//a:PaintDtl">
														<xsl:if test="a:GId = $ThisGId">
															<xsl:value-of select="//a:Paint//a:PaintDtl[a:GId = $ThisGId]/a:RepTyp"/>
														</xsl:if>
													</xsl:for-each>
												</xsl:for-each>&#xA0;</td>
											<td align="left" class="w_table" style="border-right:#000000 solid 1px">
												<xsl:element name="div">
													<xsl:attribute name="class">invisible_div</xsl:attribute>
													<xsl:attribute name="id">c_div_<xsl:value-of select="position()"/></xsl:attribute>&#xA0;</xsl:element>

												<xsl:element name="select">
													<xsl:attribute name="class">input_select</xsl:attribute>
													<xsl:attribute name="style">width: 100%</xsl:attribute>
													<xsl:attribute name="onchange">comboBoxChange(this,'c_div_<xsl:value-of select="position()"/>')</xsl:attribute>
													<xsl:element name="option">
														<xsl:attribute name="value"></xsl:attribute>
													</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">разбито</xsl:attribute>разбито</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">расколото</xsl:attribute>расколото</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">скол</xsl:attribute>скол</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">трещина</xsl:attribute>трещина</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">погнуто</xsl:attribute>погнуто</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. >50% пов.</xsl:attribute>деф. >50% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤30% пов.</xsl:attribute>деф. ≤30% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤10% пов.</xsl:attribute>деф. ≤10% пов.</xsl:element>
												</xsl:element>
											</td>
										</tr>
									</xsl:for-each>

									<xsl:for-each select="a:Task/a:CalculationList/a:CLASSCalculation/a:CLASSResult/a:CLASSXml/a:CalcData/a:Labor/a:NDtls/a:NDtl">
										<xsl:variable name="ThisGId" select="a:GId"/>
										<tr class=" " height="20">
											<td width="103" align="center" nowrap="nowrap" class="w_table">
												<xsl:value-of select="a:GId"/>
											</td>
											<td class="w_table">
												<xsl:choose>
													<xsl:when test="a:PartDesc">
														<xsl:value-of select="a:PartDesc"/>
													</xsl:when>
													<xsl:otherwise>
														<xsl:value-of select="a:RepDesc"/>
													</xsl:otherwise>
												</xsl:choose>
											</td>
											<td align="center" class="w_table">
												<xsl:value-of select="a:RepTyp"/>
											</td>
											<td align="center" class="w_table">
												<xsl:if test="a:WuNet[@DspChar = '*'] or a:WuNo[@DspChar = '*']">
													<xsl:choose>
														<xsl:when test="a:WuNo">
															<xsl:value-of select="format-number(substring-after(a:WuNo/@Val,'+'), '###0.0 ')"/>
														</xsl:when>
														<xsl:when test="a:WuNet">
															<xsl:value-of select="format-number(substring-after(a:WuNet/@Val,'+'), '###0.0 ')"/>
														</xsl:when>
													</xsl:choose>
												</xsl:if>&#xA0;</td>
											<td width="200" align="center" class="w_table">
												<xsl:for-each select="//a:Paint">
													<xsl:for-each select="//a:PaintDtl">
														<xsl:if test="a:GId = $ThisGId">
															<xsl:value-of select="//a:Paint//a:PaintDtl[a:GId = $ThisGId]/a:RepTyp"/>
														</xsl:if>
													</xsl:for-each>
												</xsl:for-each>&#xA0;</td>
											<td align="left" class="w_table" style="border-right:#000000 solid 1px">
												<xsl:element name="div">
													<xsl:attribute name="class">invisible_div</xsl:attribute>
													<xsl:attribute name="id">2c_div_<xsl:value-of select="position()"/></xsl:attribute>&#xA0;</xsl:element>
												<xsl:element name="select">
													<xsl:attribute name="class">input_select</xsl:attribute>
													<xsl:attribute name="style">width: 100%</xsl:attribute>
													<xsl:attribute name="onchange">comboBoxChange(this,'2c_div_<xsl:value-of select="position()"/>')</xsl:attribute>
													<xsl:element name="option">
														<xsl:attribute name="value"></xsl:attribute>
													</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">разбито</xsl:attribute>разбито</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">расколото</xsl:attribute>расколото</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">скол</xsl:attribute>скол</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">трещина</xsl:attribute>трещина</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">погнуто</xsl:attribute>погнуто</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. >50% пов.</xsl:attribute>деф. >50% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤30% пов.</xsl:attribute>деф. ≤30% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤10% пов.</xsl:attribute>деф. ≤10% пов.</xsl:element>
												</xsl:element>
											</td>
										</tr>
									</xsl:for-each>

									<xsl:for-each select="a:Task/a:CalculationList/a:CLASSCalculation/a:CLASSResult/a:CLASSXml/a:CalcData/a:Labor/a:IDtls/a:IDtl">
										<xsl:variable name="ThisGId" select="a:GId"/>
										<tr class=" " height="20">
											<td width="103" align="center" nowrap="nowrap" class="w_table">
												<xsl:value-of select="a:GId"/>
											</td>
											<td class="w_table">
												<xsl:choose>
													<xsl:when test="a:PartDesc">
														<xsl:value-of select="a:PartDesc"/>
													</xsl:when>
													<xsl:otherwise>
														<xsl:value-of select="a:RepDesc"/>
													</xsl:otherwise>
												</xsl:choose>
											</td>
											<td align="center" class="w_table">
												<xsl:value-of select="a:RepTyp"/>
											</td>
											<td align="center" class="w_table">
												<xsl:if test="a:WuNet[@DspChar = '*'] or a:WuNo[@DspChar = '*']">
													<xsl:choose>
														<xsl:when test="a:WuNo">
															<xsl:value-of select="format-number(substring-after(a:WuNo/@Val,'+'), '###0.0 ')"/>
														</xsl:when>
														<xsl:when test="a:WuNet">
															<xsl:value-of select="format-number(substring-after(a:WuNet/@Val,'+'), '###0.0 ')"/>
														</xsl:when>
													</xsl:choose>
												</xsl:if>&#xA0;</td>
											<td width="200" align="center" class="w_table">
												<xsl:for-each select="//a:Paint">
													<xsl:for-each select="//a:PaintDtl">
														<xsl:if test="a:GId = $ThisGId">
															<xsl:value-of select="//a:Paint//a:PaintDtl[a:GId = $ThisGId]/a:RepTyp"/>
														</xsl:if>
													</xsl:for-each>
												</xsl:for-each>&#xA0;</td>
											<td align="left" class="w_table" style="border-right:#000000 solid 1px">
												<xsl:element name="div">
													<xsl:attribute name="class">invisible_div</xsl:attribute>
													<xsl:attribute name="id">3c_div_<xsl:value-of select="position()"/></xsl:attribute>&#xA0;</xsl:element>
												<xsl:element name="select">
													<xsl:attribute name="class">input_select</xsl:attribute>
													<xsl:attribute name="style">width: 100%</xsl:attribute>
													<xsl:attribute name="onchange">comboBoxChange(this,'3c_div_<xsl:value-of select="position()"/>')</xsl:attribute>
													<xsl:element name="option">
														<xsl:attribute name="value"></xsl:attribute>
													</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">разбито</xsl:attribute>разбито</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">расколото</xsl:attribute>расколото</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">скол</xsl:attribute>скол</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">трещина</xsl:attribute>трещина</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">погнуто</xsl:attribute>погнуто</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. >50% пов.</xsl:attribute>деф. >50% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤30% пов.</xsl:attribute>деф. ≤30% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤10% пов.</xsl:attribute>деф. ≤10% пов.</xsl:element>
												</xsl:element>
											</td>
										</tr>
									</xsl:for-each>

									<xsl:for-each select="a:Task/a:CalculationList/a:CLASSCalculation/a:CLASSResult/a:CLASSXml/a:CalcData/a:Labor/a:UDtls/a:UDtl">
										<xsl:variable name="ThisGId" select="a:GId"/>
										<tr class=" " height="20">
											<td width="103" align="center" nowrap="nowrap" class="w_table">
												<xsl:value-of select="a:GId"/>
											</td>
											<td class="w_table">
												<xsl:choose>
													<xsl:when test="a:PartDesc">
														<xsl:value-of select="a:PartDesc"/>
													</xsl:when>
													<xsl:otherwise>
														<xsl:value-of select="a:RepDesc"/>
													</xsl:otherwise>
												</xsl:choose>
											</td>
											<td align="center" class="w_table">
												<xsl:value-of select="a:RepTyp"/>
											</td>
											<td align="center" class="w_table">
												<xsl:if test="a:WuNet[@DspChar = '*'] or a:WuNo[@DspChar = '*']">
													<xsl:choose>
														<xsl:when test="a:WuNo">
															<xsl:value-of select="format-number(substring-after(a:WuNo/@Val,'+'), '###0.0 ')"/>
														</xsl:when>
														<xsl:when test="a:WuNet">
															<xsl:value-of select="format-number(substring-after(a:WuNet/@Val,'+'), '###0.0 ')"/>
														</xsl:when>
													</xsl:choose>
												</xsl:if>
											</td>
											<td width="200" align="center" class="w_table">
												<xsl:for-each select="//a:Paint">
													<xsl:for-each select="//a:PaintDtl">
														<xsl:if test="a:GId = $ThisGId">
															<xsl:value-of select="//a:Paint//a:PaintDtl[a:GId = $ThisGId]/a:RepTyp"/>
														</xsl:if>
													</xsl:for-each>
												</xsl:for-each>&#xA0;</td>
											<td align="left" class="w_table" style="border-right:#000000 solid 1px">
												<xsl:element name="div">
													<xsl:attribute name="class">invisible_div</xsl:attribute>
													<xsl:attribute name="id">3c_div_<xsl:value-of select="position()"/></xsl:attribute>&#xA0;</xsl:element>
												<xsl:element name="select">
													<xsl:attribute name="class">input_select</xsl:attribute>
													<xsl:attribute name="style">width: 100%</xsl:attribute>
													<xsl:attribute name="onchange">comboBoxChange(this,'3c_div_<xsl:value-of select="position()"/>')</xsl:attribute>
													<xsl:element name="option">
														<xsl:attribute name="value"></xsl:attribute>
													</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">разбито</xsl:attribute>разбито</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">расколото</xsl:attribute>расколото</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">скол</xsl:attribute>скол</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">трещина</xsl:attribute>трещина</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">погнуто</xsl:attribute>погнуто</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. >50% пов.</xsl:attribute>деф. >50% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤30% пов.</xsl:attribute>деф. ≤30% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤10% пов.</xsl:attribute>деф. ≤10% пов.</xsl:element>
												</xsl:element>
											</td>
										</tr>
									</xsl:for-each>

									<xsl:for-each select="a:Task/a:CalculationList/a:CLASSCalculation/a:CLASSResult/a:CLASSXml/a:CalcData/a:Labor/a:HDtls/a:HDtl">
										<xsl:variable name="ThisGId" select="a:GId"/>
										<tr class=" " height="20">
											<td width="103" align="center" nowrap="nowrap" class="w_table">
												<xsl:value-of select="a:GId"/>
											</td>
											<td class="w_table">
												<xsl:choose>
													<xsl:when test="a:PartDesc">
														<xsl:value-of select="a:PartDesc"/>
													</xsl:when>
													<xsl:otherwise>
														<xsl:value-of select="a:RepDesc"/>
													</xsl:otherwise>
												</xsl:choose>
											</td>
											<td align="center" class="w_table">
												<xsl:value-of select="a:RepTyp"/>
											</td>
											<td align="center" class="w_table">
												<xsl:if test="a:WuNet[@DspChar = '*'] or a:WuNo[@DspChar = '*']">
													<xsl:choose>
														<xsl:when test="a:WuNo">
															<xsl:value-of select="format-number(substring-after(a:WuNo/@Val,'+'), '###0.0 ')"/>
														</xsl:when>
														<xsl:when test="a:WuNet">
															<xsl:value-of select="format-number(substring-after(a:WuNet/@Val,'+'), '###0.0 ')"/>
														</xsl:when>
													</xsl:choose>
												</xsl:if>&#xA0;</td>
											<td width="200" align="center" class="w_table">
												<xsl:if test="a:RepTyp != 'H'">
													<xsl:for-each select="//a:Paint">
														<xsl:for-each select="//a:PaintDtl">
															<xsl:if test="a:GId = $ThisGId">
																<xsl:value-of select="//a:Paint//a:PaintDtl[a:GId = $ThisGId]/a:RepTyp"/>
															</xsl:if>
														</xsl:for-each>
													</xsl:for-each>
												</xsl:if>&#xA0;</td>
											<td align="left" class="w_table" style="border-right:#000000 solid 1px">
												<xsl:element name="div">
													<xsl:attribute name="class">invisible_div</xsl:attribute>
													<xsl:attribute name="id">3c_div_<xsl:value-of select="position()"/></xsl:attribute>&#xA0;</xsl:element>
												<xsl:element name="select">
													<xsl:attribute name="class">input_select</xsl:attribute>
													<xsl:attribute name="style">width: 100%</xsl:attribute>
													<xsl:attribute name="onchange">comboBoxChange(this,'3c_div_<xsl:value-of select="position()"/>')</xsl:attribute>
													<xsl:element name="option">
													</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">разбито</xsl:attribute>разбито</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">расколото</xsl:attribute>расколото</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">скол</xsl:attribute>скол</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">трещина</xsl:attribute>трещина</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">погнуто</xsl:attribute>погнуто</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. >50% пов.</xsl:attribute>деф. >50% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤30% пов.</xsl:attribute>деф. ≤30% пов.</xsl:element>
													<xsl:element name="option">
														<xsl:attribute name="value">деф. ≤10% пов.</xsl:attribute>деф. ≤10% пов.</xsl:element>
												</xsl:element>
											</td>
										</tr>
									</xsl:for-each>

									<!--<xsl:for-each select="a:Task/a:CalculationList/a:CLASSCalculation/a:CLASSResult/a:CLASSXml/a:CalcData/a:Paint/a:PaintPositions/a:PaintDtl">
                        <xsl:variable name="ThisGId" select="a:GId"/>
                      <tr class=" " height="20">
                        <td width="50" align="center" nowrap="nowrap" class="w_table"><xsl:value-of select="a:GId"/></td>
                        <td class="w_table">
                            <xsl:value-of select="a:Desc"/>&#xA0;(<xsl:value-of select="a:RepTypDesc"/>)                        </td>
                          <td align="center" class="w_table"></td>
                          <td align="center" class="w_table">
                        <xsl:if test="a:WuNet[@DspChar = '*'] or a:WuNo[@DspChar = '*']">
                          <xsl:choose>
                            <xsl:when test="a:WuNo">
                                    <xsl:value-of select="format-number(substring-after(a:WuNo/@Val,'+'), '###0.0 ')"/> 
                            </xsl:when>
                            <xsl:when test="a:WuNet">
                                    <xsl:value-of select="format-number(substring-after(a:WuNet/@Val,'+'), '###0.0 ')"/> 
                            </xsl:when>
                          </xsl:choose>
                        </xsl:if>                          </td>
                          <td align="center" class="w_table">
                          <xsl:if test = "a:RepTyp != 'H'">
                              <xsl:for-each select="//a:Paint">
                                <xsl:for-each select="//a:PaintDtl">
                                  <xsl:if test = "a:GId = $ThisGId">
                                            <xsl:value-of select="//a:Paint//a:PaintDtl[a:GId = $ThisGId]/a:RepTyp"/>
                                  </xsl:if>
                                </xsl:for-each>
                              </xsl:for-each>					  
                          </xsl:if>                          </td>
                          <td align="left" class="w_table">
                          <xsl:element name="div">
                              <xsl:attribute  name = "class">invisible_div</xsl:attribute>
                              <xsl:attribute  name = "id">3c_div_<xsl:value-of select="position()"/></xsl:attribute>
                          </xsl:element>                             
                      <xsl:element name="select">
                          <xsl:attribute  name = "class">input_select</xsl:attribute> 
                          <xsl:attribute  name = "style">width: 100%</xsl:attribute>
                          <xsl:attribute  name = "onchange">comboBoxChange(this,'3c_div_<xsl:value-of select="position()"/>')</xsl:attribute>
                          		<xsl:element name="option">
                                    <xsl:attribute name="value"></xsl:attribute>
                                </xsl:element>                                                 
                          		<xsl:element name="option">
                                    <xsl:attribute name="value">разбито</xsl:attribute>разбито
                                </xsl:element>
                          		<xsl:element name="option">
                                    <xsl:attribute name="value">расколото</xsl:attribute>расколото
                                </xsl:element>       
                          		<xsl:element name="option">
                                    <xsl:attribute name="value">скол</xsl:attribute>скол
                                </xsl:element>       
                          		<xsl:element name="option">
                                    <xsl:attribute name="value">трещина</xsl:attribute>трещина
                                </xsl:element>       
                          		<xsl:element name="option">
                                    <xsl:attribute name="value">погнуто</xsl:attribute>погнуто
                                </xsl:element>
                          		<xsl:element name="option">
                                    <xsl:attribute name="value">деф. >50% пов.</xsl:attribute>деф. >50% пов.
                                </xsl:element>
                           		<xsl:element name="option">
                                    <xsl:attribute name="value">деф. ≤30% пов.</xsl:attribute>деф. ≤30% пов.
                                </xsl:element>                                                            
                           		<xsl:element name="option">
                                    <xsl:attribute name="value">деф. ≤10% пов.</xsl:attribute>деф. ≤10% пов.
                                </xsl:element>                                                            
                      </xsl:element></td>
                      </tr>
                    </xsl:for-each> -->
								</tbody>
							</table>
						</td>
					</tr>

					<tr>
						<td colspan="2" class="top_borders">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2" class="explanation">E - Замена, ET - Частичная    замена, TE - Запасная часть для частичной замены, I - Ремонт, IT - Частичный    ремонт, N - Сопутствующие работы
      (снятие, установка и т.п.),    P - Проверка, V - Измерение LE - Окраска новых деталей, LI - Ремонтная    окраска, LI1 - Ремонтная окраска, L - Окраска поверхности</td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2">Снять, установить детали, препятствующие проведению ремонтных работ. Заменить детали разового монтажа и подлежащие замене согласно технологии завода - изготовителя. Учесть стоимость материалов, окраски необходимых для ремонта.		  Возможны скрытые повреждения.</td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;
							<table width="100%" border="0" cellspacing="0" cellpadding="0">
								<tr>
									<td width="24%">Осмотр выполнил:</td>
									<td width="76%" id="expert">&#xA0;</td>
								</tr>
								<tr>
									<td>Инженер-автоэксперт</td>
									<td id="expert2">&#xA0;</td>
								</tr>
							</table>
						</td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;</td>
					</tr>
					<tr>
						<td colspan="2">
							<p>С актом осмотра согласен:  _______________________________________________________________________ <br/>
      Страхователь (выгодоприобретатель)</p>
							<p>Другие  заинтересованные лица</p>
						</td>
					</tr>
					<tr>
						<td colspan="2">&#xA0;</td>
					</tr>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet><!-- Stylus Studio meta-information - (c) 2004-2009. Progress Software Corporation. All rights reserved.

<metaInformation>
	<scenarios>
		<scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="Акт осмотра.xml" htmlbaseurl="" outputurl="" processortype="saxon8" useresolver="yes" profilemode="0" profiledepth="" profilelength="" urlprofilexml=""
		          commandline="" additionalpath="" additionalclasspath="" postprocessortype="none" postprocesscommandline="" postprocessadditionalpath="" postprocessgeneratedext="" validateoutput="no" validator="internal" customvalidator="">
			<advancedProp name="sInitialMode" value=""/>
			<advancedProp name="bXsltOneIsOkay" value="true"/>
			<advancedProp name="bSchemaAware" value="true"/>
			<advancedProp name="bXml11" value="false"/>
			<advancedProp name="iValidation" value="0"/>
			<advancedProp name="bExtensions" value="true"/>
			<advancedProp name="iWhitespace" value="0"/>
			<advancedProp name="sInitialTemplate" value=""/>
			<advancedProp name="bTinyTree" value="true"/>
			<advancedProp name="bWarnings" value="true"/>
			<advancedProp name="bUseDTD" value="false"/>
			<advancedProp name="iErrorHandling" value="fatal"/>
		</scenario>
		<scenario default="no" name="Scenario2" userelativepaths="yes" externalpreview="no" url="" htmlbaseurl="" outputurl="" processortype="saxon8" useresolver="yes" profilemode="0" profiledepth="" profilelength="" urlprofilexml="" commandline=""
		          additionalpath="" additionalclasspath="" postprocessortype="none" postprocesscommandline="" postprocessadditionalpath="" postprocessgeneratedext="" validateoutput="no" validator="internal" customvalidator="">
			<advancedProp name="sInitialMode" value=""/>
			<advancedProp name="bXsltOneIsOkay" value="true"/>
			<advancedProp name="bSchemaAware" value="true"/>
			<advancedProp name="bXml11" value="false"/>
			<advancedProp name="iValidation" value="0"/>
			<advancedProp name="bExtensions" value="true"/>
			<advancedProp name="iWhitespace" value="0"/>
			<advancedProp name="sInitialTemplate" value=""/>
			<advancedProp name="bTinyTree" value="true"/>
			<advancedProp name="bWarnings" value="true"/>
			<advancedProp name="bUseDTD" value="false"/>
			<advancedProp name="iErrorHandling" value="fatal"/>
		</scenario>
	</scenarios>
	<MapperMetaTag>
		<MapperInfo srcSchemaPathIsRelative="yes" srcSchemaInterpretAsXML="no" destSchemaPath="" destSchemaRoot="" destSchemaPathIsRelative="yes" destSchemaInterpretAsXML="no">
			<SourceSchema srcSchemaPath="Акт осмотра.xml" srcSchemaRoot="Расчет" AssociatedInstance="" loaderFunction="document" loaderFunctionUsesURI="no"/>
		</MapperInfo>
		<MapperBlockPosition>
			<template match="/">
				<block path="html/body/table/tr[2]/td/xsl:element/xsl:attribute[2]/xsl:value-of" x="167" y="37"/>
				<block path="html/body/table/tr[10]/td/xsl:element/xsl:attribute[3]/xsl:value-of" x="127" y="37"/>
				<block path="html/body/table/tr[13]/td/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[13]/td/xsl:value-of[1]" x="287" y="77"/>
				<block path="html/body/table/tr[13]/td/xsl:value-of[2]" x="207" y="77"/>
				<block path="html/body/table/tr[15]/td/table/tr/td[1]/xsl:value-of" x="287" y="117"/>
				<block path="html/body/table/tr[15]/td/table/tr/td[1]/xsl:value-of[1]" x="207" y="117"/>
				<block path="html/body/table/tr[15]/td/table/tr/td[1]/xsl:value-of[2]" x="167" y="117"/>
				<block path="html/body/table/tr[15]/td/table/tr/td[3]/xsl:value-of" x="127" y="117"/>
				<block path="html/body/table/tr[15]/td/table/tr[1]/td[3]/xsl:value-of" x="87" y="117"/>
				<block path="html/body/table/tr[15]/td/table/tr[1]/td[3]/xsl:value-of/substring[0]" x="41" y="115"/>
				<block path="html/body/table/tr[15]/td/table/tr[2]/td[1]/xsl:value-of" x="47" y="117"/>
				<block path="html/body/table/tr[15]/td/table/tr[2]/td[3]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[15]/td/table/tr[2]/td[3]/xsl:value-of[1]" x="247" y="77"/>
				<block path="html/body/table/tr[19]/td/table/xsl:for-each" x="217" y="47"/>
				<block path="html/body/table/tr[19]/td/table/xsl:for-each/xsl:choose" x="87" y="37"/>
				<block path="html/body/table/tr[19]/td/table/xsl:for-each/xsl:choose[1]" x="247" y="117"/>
				<block path="html/body/table/tr[19]/td/table/xsl:for-each/xsl:choose[1]/xsl:when/td/xsl:if/or[0]" x="171" y="45"/>
				<block path="html/body/table/tr[19]/td/table/xsl:for-each/xsl:choose[1]/xsl:when/td/xsl:if/or[0]/!=[1]" x="125" y="67"/>
				<block path="html/body/table/tr[19]/td/table/xsl:for-each/xsl:choose[1]/xsl:when/td/xsl:if" x="217" y="47"/>
				<block path="html/body/table/tr[19]/td/table/xsl:for-each/xsl:choose[1]/xsl:when/td/xsl:if/xsl:value-of" x="47" y="37"/>
				<block path="html/body/table/tr[21]/td[1]/xsl:value-of" x="167" y="77"/>
				<block path="html/body/table/tr[21]/td[1]/xsl:value-of[1]" x="127" y="77"/>
				<block path="html/body/table/tr[21]/td[1]/xsl:value-of[2]" x="87" y="77"/>
				<block path="html/body/table/tr[23]/td[1]/xsl:value-of" x="47" y="77"/>
				<block path="html/body/table/tr[23]/td[1]/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[23]/td[1]/xsl:choose/xsl:when/xsl:value-of" x="247" y="37"/>
				<block path="html/body/table/tr[23]/td[1]/xsl:choose/xsl:otherwise/xsl:value-of" x="287" y="37"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[1]/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[1]/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[1]/xsl:choose/xsl:otherwise/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[2]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each" x="127" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each/xsl:if/=[0]" x="191" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each/xsl:if" x="237" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each/xsl:if/xsl:if/or[0]" x="141" y="15"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each/xsl:if/xsl:if" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each/xsl:if/xsl:if/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each/xsl:if/xsl:if/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each/xsl:if/xsl:if/xsl:choose/xsl:when/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each/xsl:if/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[3]/xsl:for-each/xsl:if/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[4]/xsl:for-each" x="277" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[4]/xsl:for-each/xsl:for-each" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if/=[0]" x="171" y="45"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[5]/xsl:element/xsl:attribute[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each/tr/td[5]/xsl:element[1]/xsl:attribute[2]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[1]/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[1]/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[1]/xsl:choose/xsl:otherwise/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[2]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[3]/xsl:if/or[0]" x="141" y="15"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[3]/xsl:if" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[3]/xsl:if/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[3]/xsl:if/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[3]/xsl:if/xsl:choose/xsl:when/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[3]/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[3]/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[4]/xsl:for-each" x="77" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[4]/xsl:for-each/xsl:for-each" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if/=[0]" x="171" y="45"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[5]/xsl:element/xsl:attribute[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[1]/tr/td[5]/xsl:element[1]/xsl:attribute[2]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[1]/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[1]/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[1]/xsl:choose/xsl:otherwise/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[2]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[3]/xsl:if/or[0]" x="141" y="15"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[3]/xsl:if" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[3]/xsl:if/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[3]/xsl:if/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[3]/xsl:if/xsl:choose/xsl:when/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[3]/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[3]/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[4]/xsl:for-each" x="37" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[4]/xsl:for-each/xsl:for-each" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if/=[0]" x="171" y="45"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[5]/xsl:element/xsl:attribute[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[2]/tr/td[5]/xsl:element[1]/xsl:attribute[2]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[1]/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[1]/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[1]/xsl:choose/xsl:otherwise/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[2]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[3]/xsl:if/or[0]" x="141" y="15"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[3]/xsl:if" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[3]/xsl:if/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[3]/xsl:if/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[3]/xsl:if/xsl:choose/xsl:when/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[3]/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[3]/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[4]/xsl:for-each" x="157" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[4]/xsl:for-each/xsl:for-each" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if/=[0]" x="171" y="45"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[4]/xsl:for-each/xsl:for-each/xsl:if/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[5]/xsl:element/xsl:attribute[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[3]/tr/td[5]/xsl:element[1]/xsl:attribute[2]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[1]/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[1]/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[1]/xsl:choose/xsl:otherwise/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[2]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[3]/xsl:if/or[0]" x="141" y="15"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[3]/xsl:if" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[3]/xsl:if/xsl:choose" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[3]/xsl:if/xsl:choose/xsl:when/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[3]/xsl:if/xsl:choose/xsl:when/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[3]/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[3]/xsl:if/xsl:choose/xsl:when[1]/xsl:value-of/substring-after[0]" x="201" y="71"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[4]/xsl:if/!=[0]" x="81" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[4]/xsl:if" x="127" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[4]/xsl:if/xsl:for-each" x="157" y="0"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[4]/xsl:if/xsl:for-each/xsl:for-each" x="187" y="17"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[4]/xsl:if/xsl:for-each/xsl:for-each/xsl:if/=[0]" x="171" y="45"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[4]/xsl:if/xsl:for-each/xsl:for-each/xsl:if" x="217" y="47"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[4]/xsl:if/xsl:for-each/xsl:for-each/xsl:if/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[5]/xsl:element/xsl:attribute[1]/xsl:value-of" x="247" y="77"/>
				<block path="html/body/table/tr[35]/td/table/tbody/xsl:for-each[4]/tr/td[5]/xsl:element[1]/xsl:attribute[2]/xsl:value-of" x="247" y="77"/>
			</template>
		</MapperBlockPosition>
		<TemplateContext></TemplateContext>
		<MapperFilter side="source"></MapperFilter>
	</MapperMetaTag>
</metaInformation>
-->