

function validarFormulario(evt) {
    const dni = document.getElementById('txtDni');
    const nombre = document.getElementById('txtNombre');
    const apellido = document.getElementById('txtApellido');
    const email = document.getElementById('txtEmail');
    const direccion = document.getElementById('txtDireccion');
    const ciudad = document.getElementById('txtCiudad');
    const cp = document.getElementById('txtCp');
    const chkTerminos = document.getElementById('chkTerminos');

    const reEmail = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    const reDni = /^\d{7,8}$/;
    const reCp = /^(?:\d{4}|[A-Za-z0-9]{4,8})$/;

    function hint(id, show) {
        const element = document.getElementById(id);
        if (!element) return;
        element.classList.toggle('d-none', !show);
    }

    function state(input, ok, hintId) {
        input.classList.toggle('is-valid', ok);
        input.classList.toggle('is-invalid', !ok);
        if (hintId) hint(hintId, !ok);
        return ok;
    }

    function validateDni() { return state(dni, reDni.test(dni.value.trim()), 'hint-dni'); }
    function validateNombre() { return state(nombre, nombre.value.trim().length > 0, 'hint-nombre'); }
    function validateApellido() { return state(apellido, apellido.value.trim().length > 0, 'hint-apellido'); }
    function validateEmail() { return state(email, reEmail.test(email.value.trim()), 'hint-email'); }
    function validateDireccion() { return state(direccion, direccion.value.trim().length > 0, 'hint-direccion'); }
    function validateCiudad() { return state(ciudad, ciudad.value.trim().length > 0, 'hint-ciudad'); }
    function validateCp() { return state(cp, reCp.test(cp.value.trim()), 'hint-cp'); }
    function validateTerminos() { const ok = !!(chkTerminos && chkTerminos.checked); hint('hint-terminos', !ok); return ok; }

    [dni, nombre, apellido, email, direccion, ciudad, cp]
        .filter(Boolean)
        .forEach(element => { // Validación en tiempo real
        element.addEventListener('input', () => {
            switch (element.id) {
                case 'txtDni': validateDni(); break;
                case 'txtNombre': validateNombre(); break;
                case 'txtApellido': validateApellido(); break;
                case 'txtEmail': validateEmail(); break;
                case 'txtDireccion': validateDireccion(); break;
                case 'txtCiudad': validateCiudad(); break;
                case 'txtCp': validateCp(); break;
            }
        });
        element.addEventListener('blur', () => element.dispatchEvent(new Event('input'))); // Forzar validación al perder foco
    });

       
        const allValid = [validateDni(), validateNombre(), validateApellido(), validateEmail(), validateDireccion(), validateCiudad(), validateCp(), validateTerminos()].every(Boolean);
        if (!allValid) {
            if (evt && typeof evt.preventDefault === 'function') evt.preventDefault();
            alert('Por favor, corrija los errores en el formulario antes de enviarlo.');
            return false;
        }
        return true;
}


function showToast(id) {
    const toastEl = document.getElementById(id);
    if (toastEl) {
        const toast = new bootstrap.Toast(toastEl);
        toast.show();
    }
}

function salir(url = '/Default.aspx') {
    console.log(`Redireccionando a: " + url en ${delay / 1000} segundos...`);
    setTimeout(() => {
        window.location.href = url;
    }, delay);
}