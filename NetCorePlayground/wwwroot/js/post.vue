
<template>
	<li>{{ entry.title }}</li>
</template>
<script>
	var postComponent = Vue.component('post', {
		props: ['entry'],

	})
	export default postComponent;
</script>