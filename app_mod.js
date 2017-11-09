
var form = $('#customers'),
    cache_width = form.width(),
    a4 = [595.28, 990.89]; // for a4 size paper width and height

var canvasImage,
    winHeight = a4[1],
    formHeight = form.height(),
    formWidth  = form.width();
	/* alert(formWidth);
alert(formHeight);
 */
var imagePieces = [];

// on create pdf button click
$('#create_pdf').on('click', function() {
	//$('#spinicon').show();
	//bootbox.alert("Download started..");
    $('body').scrollTop(0);
    imagePieces = [];
    imagePieces.length = 0;
    main();
	//$('#spinicon').hide();
	
	
});
    
// main code
function main() {
    getCanvas().then(function(canvas){
        canvasImage = new Image();
        canvasImage.src= canvas.toDataURL("image/png");
        canvasImage.onload = splitImage;
    });
}

// create canvas object
function getCanvas() {
    form.width((a4[0] * 1.33333) - 80).css('max-width', 'none');
	//  form.width((a4[0] * 1.33333)).css('max-width', 'none');
    return html2canvas(form, {
        imageTimeout: 200,
        removeContainer: true
    });
}

// chop image horizontally
function splitImage(e) {
    var totalImgs = Math.round(formHeight/winHeight);
    for(var i = 0; i < totalImgs; i++) {
        var canvas = document.createElement('canvas'),
            ctx = canvas.getContext('2d');
        canvas.width = formWidth;
        canvas.height = winHeight;
        //                    source region                   dest. region
        ctx.drawImage(canvasImage, 0, i * winHeight, formWidth, winHeight, 0, 0, canvas.width, canvas.height);
        
        imagePieces.push(canvas.toDataURL("image/png"));
    }
    console.log(imagePieces.length);
    createPDF();
}

// crete pdf using chopped images
function createPDF() {
    var totalPieces = imagePieces.length - 1;
    var doc = new jsPDF({
        unit: 'px',
        format: 'a4'
    });
    imagePieces.forEach(function(img){
        doc.addImage(img, 'JPEG', 20, 40);
        if(totalPieces)
            doc.addPage();
        totalPieces--;
    });
    doc.save('application-html-to-pdf.pdf');
    form.width(cache_width);
	//$('#spinicon').hide();
	//bootbox.alert("Download completed..");
}
